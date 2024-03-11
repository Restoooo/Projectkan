Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class MenuMakan
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cmd2 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim reader2 As MySqlDataReader


    Public Shared pesanan As New List(Of String)()
    Public Shared totalharga As Integer = 0




    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        Report.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonStatus_Click(sender As Object, e As EventArgs) Handles ButtonStatus.Click
        Status.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonStock_Click(sender As Object, e As EventArgs) Handles ButtonStock.Click
        Stock.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonBurgerMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenuBurger.Click
        If PanelLeft.Width > 50 Then
            TimerPanelReduce.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub

    Private Sub TimerPanelReduce_Tick(sender As Object, e As EventArgs) Handles TimerPanelReduce.Tick
        If PanelLeft.Width > 50 Then
            ButtonDashboard.Width -= 5
            ButtonMenu.Width -= 5
            ButtonStock.Width -= 5
            ButtonReport.Width -= 5
            PanelLeft.Width -= 5
            ButtonDashboard.Text = ""
            ButtonMenu.Text = ""
            ButtonStock.Text = ""
            ButtonReport.Text = ""
        Else
            TimerPanelReduce.Enabled = False
        End If
    End Sub
    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelIncrease.Tick
        If PanelLeft.Width < 200 Then
            ButtonDashboard.Width += 5
            ButtonMenu.Width += 5
            ButtonStock.Width += 5
            ButtonReport.Width += 5
            PanelLeft.Width += 5
            ButtonDashboard.Text = "Dashboard"
            ButtonMenu.Text = "Menu"
            ButtonStock.Text = "Stock"
            ButtonReport.Text = "Report"
        Else
            TimerPanelIncrease.Enabled = False
        End If
    End Sub


    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Login.idAkun = -1
        Login.Jabatan = ""
        Login.NamaKaryawan = ""
        Login.Username = ""
        Login.txtPass.Text = "Password"
        Login.txtUsername.Text = "Username"
        Status.TimerStatus.Stop()
        Login.Show()
        Me.Hide()
    End Sub
    'Private Sub InitializeMenu()
    '   conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
    '  conn.Open()
    ' cmd = New MySqlCommand("SELECT id_menu, stok FROM Menu where jenis = 'makanan'", conn)
    'Dim reader As MySqlDataReader = cmd.ExecuteReader()
    '  jumlahMenuChecker.Clear()
    '   While reader.Read()
    'Dim idMenu As Integer = Convert.ToInt32(reader("id_menu"))
    'Dim stok As Integer = Convert.ToInt32(reader("stok"))
    '        jumlahMenuChecker.Add(idMenu, stok)
    'End While
    '    conn.Close()
    'End Sub
    Public Sub InitializeMenuMakanMinum()
        PanelMinuman.Controls.Clear()
        PanelMakanan.Controls.Clear()
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        cmd = New MySqlCommand("SELECT m.id_menu, m.Nama, m.harga, stok - COALESCE((SELECT SUM(jumlah_pesanan) FROM detail_pesanan WHERE id_menu = m.id_menu), 0) AS remaining_stock FROM Menu m WHERE m.jenis = 'makanan';", conn)
        reader = cmd.ExecuteReader
        Dim posXMak As Integer = 25
        Dim posYMak As Integer = 0
        Dim posXMin As Integer = 25
        Dim posYMin As Integer = 0
        While reader.Read()
            Dim btn As New Button()


            Dim idMenu As Integer = Convert.ToInt32(reader("id_menu"))
            Dim remainingStock As Integer = Convert.ToInt32(reader("remaining_stock"))
            If remainingStock < 0 Then
                btn.Enabled = False
            End If
            btn.Text = reader("Nama").ToString() + " Rp. " + reader("harga").ToString
            btn.Name = "btn" & reader("id_menu").ToString()
            btn.Size = New Size(225, 30)
            btn.Location = New Point(posXMak, posYMak)
            AddHandler btn.Click, AddressOf Button_Click
            PanelMakanan.Controls.Add(btn)
            'StokModule.jumlahMenuChecker(idMenu) = remainingStock

            posYMak += 40
        End While
        conn.Close()
        conn.Open()
        cmd2 = New MySqlCommand("SELECT m.id_menu, m.Nama, m.harga, stok - COALESCE((SELECT SUM(jumlah_pesanan) FROM detail_pesanan WHERE id_menu = m.id_menu), 0) AS remaining_stock FROM Menu m WHERE m.jenis = 'minuman';", conn)
        reader2 = cmd2.ExecuteReader
        While reader2.Read()
            Dim btn As New Button()


            Dim idMenu As Integer = Convert.ToInt32(reader2("id_menu"))
            Dim remainingStock As Integer = Convert.ToInt32(reader2("remaining_stock"))
            If remainingStock < 0 Then
                btn.Enabled = False
            End If
            btn.Text = reader2("Nama").ToString() + " Rp. " + reader2("harga").ToString
            btn.Name = "btn" & reader2("id_menu").ToString()
            btn.Size = New Size(225, 30)
            btn.Location = New Point(posXMin, posYMin)
            AddHandler btn.Click, AddressOf Button_Click
            PanelMinuman.Controls.Add(btn)
            'StokModule.jumlahMenuChecker(idMenu) = remainingStock
            posYMin += 40
        End While
        conn.Close()
    End Sub
    Private Sub MenuMakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load, ButtonMenu.Click
        'InitializeMenu()
        InitializeMenuMakanMinum()
        UpdatePanePesanan()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim namaBtn As String = btn.Name
        Dim idMenu As String = namaBtn.Substring(3)
        Dim menuparts() As String = btn.Text.Split(New String() {" Rp. "}, StringSplitOptions.RemoveEmptyEntries)

        Dim namaMenu As String = menuparts(0)
        Dim hargaMenu As String = menuparts(1)
        Dim remainingStock As Integer
        If StokModule.jumlahMenuChecker.TryGetValue(Convert.ToInt32(idMenu), remainingStock) Then
            If remainingStock > 0 Then
                pesanan.Add(idMenu + " | " + namaMenu + " | " + hargaMenu)
                totalharga += Convert.ToInt32(hargaMenu)
                tbHarga.Text = totalharga.ToString()
                StokModule.jumlahMenuChecker(Convert.ToInt32(idMenu)) -= 1
                UpdatePanePesanan()
                If StokModule.jumlahMenuChecker((Convert.ToInt32(idMenu))) = 0 Then
                    btn.Enabled = False
                End If
            Else
                MessageBox.Show("This menu item is out of stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub UpdatePanePesanan()
        PanelList.Controls.Clear()
        If pesanan.Count < 1 Then
            ButtonBayar.Enabled = False
        Else
            ButtonBayar.Enabled = True
        End If
        Dim posYpesanan As Integer = 0


        For Each item As String In pesanan
            Dim label As New Label()
            label.Text = item
            label.Size = New Size(150, 30)
            label.AutoSize = True

            label.Location = New Point(0, posYpesanan)

            Dim btnDelete As New Button()
            btnDelete.Text = "x"
            btnDelete.Size = New Size(20, 20)
            btnDelete.Location = New Point(210, posYpesanan)
            AddHandler btnDelete.Click, AddressOf HapusPesanan
            btnDelete.Tag = item

            PanelList.Controls.Add(label)
            PanelList.Controls.Add(btnDelete)
            posYpesanan += 40
        Next

    End Sub
    Private Sub HapusPesanan(sender As Object, e As EventArgs)

        Dim btn As Button = DirectCast(sender, Button)
        Dim itemToRemove As String = btn.Tag.ToString()
        Dim parts() As String = itemToRemove.Split("|"c)
        pesanan.Remove(itemToRemove)
        totalharga -= parts(2)
        tbHarga.Text = totalharga.ToString
        StokModule.jumlahMenuChecker(parts(0)) += 1
        MsgBox(StokModule.jumlahMenuChecker(parts(0)).ToString + "   " + parts(0).ToString)
        UpdatePanePesanan()
    End Sub
    Private Function AmbilHargaDariString(input As String) As Double
        Dim parts() As String = input.Split("|"c)
        If parts.Length <> 3 Then
            Return 0.0
        End If
        Dim hargaStr As String = parts(2).Trim()
        Dim harga As Integer
        If Integer.TryParse(hargaStr, harga) Then
            Return harga
        Else
            Return 0.0
        End If
    End Function

    Private Sub btnResetList_Click(sender As Object, e As EventArgs) Handles btnResetList.Click
        pesanan.Clear()
        totalharga = 0
        tbHarga.Text = totalharga.ToString
        UpdatePanePesanan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MenuDuduk.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonBayar_Click(sender As Object, e As EventArgs) Handles ButtonBayar.Click
        Dim pembayaranForm As New Pembayaran(pesanan, totalharga)
        pembayaranForm.Show()
        Me.Hide()
    End Sub
End Class