Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class MenuMakan
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cmd2 As MySqlCommand
    Dim reader As MySqlDataReader
    Dim reader2 As MySqlDataReader

    Public Shared pesanan As New List(Of String)()
    Public Shared totalharga As New Integer



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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PanelLeft.Width > 50 Then
            TimerPanelReduce.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub
    Private Sub TimerPanelReduce_Tick(sender As Object, e As EventArgs) Handles TimerPanelReduce.Tick
        If PanelLeft.Width > 50 Then
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
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub MenuMakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM Menu where jenis = 'makanan'", conn)
        reader = cmd.ExecuteReader
        Dim posXMak As Integer = 25
        Dim posYMak As Integer = 0
        Dim posXMin As Integer = 25
        Dim posYMin As Integer = 0

        While reader.Read()
            Dim btn As New Button()
            btn.Text = reader("Nama").ToString() + " Rp. " + reader("harga").ToString
            btn.Name = "btn" & reader("id_menu").ToString()
            btn.Size = New Size(225, 30)
            btn.Location = New Point(posXMak, posYMak)
            AddHandler btn.Click, AddressOf Button_Click
            PanelMakanan.Controls.Add(btn)
            posYMak += 40
        End While
        conn.Close()
        conn.Open()
        cmd2 = New MySqlCommand("SELECT * FROM Menu where jenis = 'minuman'", conn)
        reader2 = cmd2.ExecuteReader
        While reader2.Read()
            Dim btn As New Button()
            btn.Text = reader2("Nama").ToString() + " Rp. " + reader2("harga").ToString
            btn.Name = "btn" & reader2("id_menu").ToString()
            btn.Size = New Size(225, 30)
            btn.Location = New Point(posXMin, posYMin)
            AddHandler btn.Click, AddressOf Button_Click
            PanelMinuman.Controls.Add(btn)
            posYMin += 40
        End While
        conn.Close()

    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim namaBtn As String = btn.Name
        Dim idMenu As String = namaBtn.Substring(3)


        Dim conn As New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        Dim cmd As New MySqlCommand("SELECT * FROM Menu WHERE id_menu = @idMenu", conn)
        cmd.Parameters.AddWithValue("@idMenu", idMenu)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim namaMenu As String = reader("Nama").ToString()
            Dim hargaMenu As String = reader("harga").ToString()
            Dim jenisMenu As String = reader("jenis").ToString()

            pesanan.Add(idMenu + " | " + namaMenu + " | " + hargaMenu)
            totalharga += hargaMenu
            tbHarga.Text = totalharga.ToString
            UpdatePanePesanan()
        End If

        conn.Close()
    End Sub
    Private Sub UpdatePanePesanan()
        PanelList.Controls.Clear()
        Dim posYpesanan As Integer = 0


        For Each item As String In pesanan
            Dim label As New Label()
            label.Text = item
            label.Size = New Size(200, 30)
            label.Location = New Point(0, posYpesanan)
            PanelList.Controls.Add(label)
            posYpesanan += 40
        Next

    End Sub

    Private Sub btnResetList_Click(sender As Object, e As EventArgs) Handles btnResetList.Click
        pesanan.Clear()
        totalharga = 0
        tbHarga.Text = totalharga.ToString
        UpdatePanePesanan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuDuduk.Show()
        Me.Hide()
    End Sub
End Class