Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Pembayaran

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public Shared tanggalnow As DateTime
    Dim countDictionary As New Dictionary(Of String, Integer)()

    Private Sub ButtonStatus_Click(sender As Object, e As EventArgs) Handles ButtonStatus.Click
        Status.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles ButtonReport.Click
        Report.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonStock_Click(sender As Object, e As EventArgs) Handles ButtonStock.Click
        Stock.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        MenuDuduk.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonBurgerMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenuBurger.Click
        If PanelLeft.Width > 50 Then
            TimerPanelReduce.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
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

    Dim orderedItems As List(Of String)
        Dim totalharga As Integer

    Public Sub New(ByVal pesanan As List(Of String), ByVal totalharga As Integer)
        InitializeComponent()
        orderedItems = pesanan
        Me.totalharga = totalharga
    End Sub

    Private Sub PembayaranForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tanggalnowload As DateTime = Date.Now
        tanggalnow = tanggalnowload
        LabelTanggal.Text = tanggalnow
        UpdatePanelPembayaran()
        If MenuDuduk.meja = 0 Then
            Label2.Text = "Meja: Takeaway"
        Else
            Label2.Text = "Meja: " + MenuDuduk.meja.ToString
        End If

        LabelNamaPelayan.Text = "Nama Pelayan: " + Login.NamaKaryawan
    End Sub

    Private Sub UpdatePanelPembayaran()
        PanelPembayaran.Controls.Clear()
        Dim posYpesanan As Integer = 0

        For Each item As String In orderedItems
            If countDictionary.ContainsKey(item) Then
                countDictionary(item) += 1
            Else
                countDictionary(item) = 1
            End If
        Next



        For Each kvp As KeyValuePair(Of String, Integer) In countDictionary
            Dim label As New Label()

            label.Size = New Size(300, 30)
            label.AutoSize = False
            label.TextAlign = ContentAlignment.MiddleLeft
            label.Padding = New Padding(0, 0, 10, 0)
            label.Location = New Point(0, posYpesanan)

            ' Extract menu name and price
            Dim parts() As String = kvp.Key.Split("|"c)
            If parts.Length = 3 Then
                label.Text = $"{parts(1).Trim()} - Rp. {parts(2).Trim()} - QTY. {kvp.Value}"
            End If

            PanelPembayaran.Controls.Add(label)
            posYpesanan += 40
        Next

        ' Add label for total payment
        Dim labelTotalHarga As New Label()
        labelTotalHarga.Text = $"Total Harga: Rp. {totalharga.ToString()}"
        labelTotalHarga.Size = New Size(300, 30)
        labelTotalHarga.AutoSize = False
        labelTotalHarga.Font = New Font(labelTotalHarga.Font.FontFamily, 12, FontStyle.Bold)
        labelTotalHarga.TextAlign = ContentAlignment.MiddleLeft
        labelTotalHarga.Location = New Point(0, posYpesanan + 20)
        PanelPembayaran.Controls.Add(labelTotalHarga)
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim transaction As MySqlTransaction = Nothing
        Try
            conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
            conn.Open()
            Try
                transaction = conn.BeginTransaction()
            Catch ex As Exception
                MsgBox("Kesalahan saat memulai transaksi: " & ex.Message)
            End Try

            Dim cmdPesanan As New MySqlCommand("INSERT INTO pesanan (id_karyawan, nama_pemesan, tanggal_pesanan, nomor_meja, harga) VALUES (@id_karyawan, @nama_pemesan, @tanggal_pesanan, @nomor_meja, @harga)", conn)
            cmdPesanan.Parameters.AddWithValue("@id_karyawan", Login.idAkun)
            cmdPesanan.Parameters.AddWithValue("@nama_pemesan", "Nama Pemesan")
            cmdPesanan.Parameters.AddWithValue("@tanggal_pesanan", tanggalnow)
            cmdPesanan.Parameters.AddWithValue("@nomor_meja", MenuDuduk.meja)
            cmdPesanan.Parameters.AddWithValue("@harga", MenuMakan.totalharga)
            cmdPesanan.Transaction = transaction
            cmdPesanan.ExecuteNonQuery()

            Dim idPesanan As Integer = CInt(cmdPesanan.LastInsertedId)

            Dim cmdDetailPesanan As New MySqlCommand("INSERT INTO detail_pesanan (id_pesanan, id_menu, jumlah_pesanan) VALUES (@id_pesanan, @id_menu, @jumlah_pesanan)", conn)

            For Each kvp As KeyValuePair(Of String, Integer) In countDictionary
                Dim menuParts() As String = kvp.Key.Split("|"c)
                Dim idMenu As Integer = Integer.Parse(menuParts(0).Trim())
                cmdDetailPesanan.Parameters.Clear()
                cmdDetailPesanan.Parameters.AddWithValue("@id_pesanan", idPesanan)
                cmdDetailPesanan.Parameters.AddWithValue("@id_menu", idMenu)
                cmdDetailPesanan.Parameters.AddWithValue("@jumlah_pesanan", kvp.Value)
                cmdDetailPesanan.Transaction = transaction
                cmdDetailPesanan.ExecuteNonQuery()

            Next


            transaction.Commit()

            MessageBox.Show("Data berhasil dimasukkan ke dalam tabel pesanan dan detail_pesanan.")
            'pembersihan data 
            MenuMakan.pesanan.Clear()
            MenuMakan.totalharga = 0
            tanggalnow = DateTime.MinValue
            Dashboard.Show()
            Me.Hide()

        Catch ex As Exception

            If transaction IsNot Nothing Then

                transaction.Rollback()
            End If
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)

        Finally
            ' Tutup koneksi
            conn.Close()
        End Try
    End Sub
End Class