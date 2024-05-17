﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Globalization
Imports System.Drawing.Printing

Public Class Pembayaran

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public Shared tanggalnow As DateTime
    Dim countDictionary As New Dictionary(Of String, Integer)()
    Dim orderedItems As List(Of String)
    Dim totalharga As Integer
    Dim Uangdibayar As Double
    Dim kembalian As Double
    Private PrintPreviewDialog1 As New PrintPreviewDialog()
    Private WithEvents PrintDocument1 As New PrintDocument()

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
        Status.TimerStatus.Stop()
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



    Public Sub New(ByVal pesanan As List(Of String), ByVal totalharga As Integer, ByVal Uangdibayar As Double, ByVal kembalian As Double)
        InitializeComponent()
        orderedItems = pesanan
        Me.totalharga = totalharga
        Me.Uangdibayar = Uangdibayar
        Me.kembalian = kembalian
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
        Dim culture As CultureInfo = New CultureInfo("id-ID")
        Dim formatMataUang As String = "Rp#,##0.00"

        LabelNamaPelayan.Text = "Nama Pelayan: " + Login.NamaKaryawan
        Dim totalhargaRupiah As String = totalharga.ToString(formatMataUang)
        Dim BayarRupiah As String = Uangdibayar.ToString(formatMataUang)
        Dim KembalianRupiah As String = kembalian.ToString(formatMataUang)
        lblKembalian.Text = "Kembalian : " & KembalianRupiah
        lblTotal.Text = "Total : " & totalhargaRupiah
        lblUang.Text = "Bayar : " & BayarRupiah
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


            Dim parts() As String = kvp.Key.Split("|"c)
            If parts.Length = 3 Then
                label.Text = $"{parts(1).Trim()} - Rp. {parts(2).Trim()} - QTY. {kvp.Value}"
            End If

            PanelPembayaran.Controls.Add(label)
            posYpesanan += 40
        Next


        'Dim labelTotalHarga As New Label()
        'labelTotalHarga.Text = $"Total Harga: Rp. {totalharga.ToString()}"
        'labelTotalHarga.Size = New Size(300, 30)
        'labelTotalHarga.AutoSize = False
        'labelTotalHarga.Font = New Font(labelTotalHarga.Font.FontFamily, 12, FontStyle.Bold)
        'labelTotalHarga.TextAlign = ContentAlignment.MiddleLeft
        'labelTotalHarga.Location = New Point(0, posYpesanan + 20)
        'PanelPembayaran.Controls.Add(labelTotalHarga)
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

            Dim cmdPesanan As New MySqlCommand("INSERT INTO pesanan (id_karyawan, tanggal_pesanan, nomor_meja, harga) VALUES (@id_karyawan, @tanggal_pesanan, @nomor_meja, @harga)", conn)
            cmdPesanan.Parameters.AddWithValue("@id_karyawan", Login.idAkun)
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

            Dim cmdUpdateStok As New MySqlCommand("UPDATE menu INNER JOIN detail_pesanan AS dp ON menu.id_menu = dp.id_menu SET menu.stok = menu.stok - dp.jumlah_pesanan WHERE dp.id_pesanan = @id_pesanan", conn)
            cmdUpdateStok.Parameters.AddWithValue("@id_pesanan", idPesanan)
            cmdUpdateStok.Transaction = transaction
            cmdUpdateStok.ExecuteNonQuery()

            Dim cmdUpdateDuduk As New MySqlCommand($"UPDATE tempat_duduk SET status = @status WHERE nomor_meja = @meja ", conn)
            cmdUpdateDuduk.Parameters.AddWithValue("@status", "Tidak")
            cmdUpdateDuduk.Parameters.AddWithValue("@meja", MenuDuduk.meja)
            cmdUpdateDuduk.Transaction = transaction
            cmdUpdateDuduk.ExecuteNonQuery()

            transaction.Commit()


            MessageBox.Show("Transaksi Berhasil")
            'pembersihan data 
            MenuMakan.PanelList.Controls.Clear()
            MenuMakan.pesanan.Clear()
            MenuMakan.totalharga = 0
            MenuMakan.tbHarga.Text = totalharga.ToString
            tanggalnow = DateTime.MinValue

            MenuDuduk.LabelNomorMeja.Text = "Nomor Meja : "
            MenuDuduk.meja = 0
            MenuDuduk.selectedButtons.Clear()

            Dim printDocument As New Printing.PrintDocument()


            AddHandler printDocument.PrintPage, AddressOf PrintPageHandler
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDocument
            printPreviewDialog.ShowDialog()

            'printDocument.Print()

        Catch ex As Exception

            If transaction IsNot Nothing Then

                transaction.Rollback()
            End If
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)

        Finally

            ' Tutup koneksi
            conn.Close()
            Dim formLoading As New Loading()
            formLoading.Show()
            Me.Hide()
        End Try
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim panelToPrint As Panel = PanelNota
        Dim pageWidth As Integer = e.PageSettings.PrintableArea.Width
        Dim pageHeight As Integer = e.PageSettings.PrintableArea.Height

        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim bmp As New Bitmap(panelToPrint.Width, panelToPrint.Height)
        panelToPrint.DrawToBitmap(bmp, New Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height))
        Dim x As Integer = 0
        Dim y As Integer = 0
        e.Graphics.DrawImage(bmp, x, y, pageWidth, pageHeight)

        ' Membersihkan sumber daya
        bmp.Dispose()
    End Sub
    Private Sub LockTable(tableNumber As Integer)
        If StokModule.lockedTables.ContainsKey(tableNumber) Then
            StokModule.lockedTables(tableNumber) = True
        End If
    End Sub

    Private Sub Pembayaran_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("Anda yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As New Font("Arial", 24)
        Dim lineHeight As Single = printFont.GetHeight(e.Graphics)
        Dim yPosition As Single = 0

        Dim pageWidth As Single = e.PageBounds.Width
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center

        ' Print each label's text content


        Dim labelResto As New Label
        labelResto.Text = "-----RESTO RECEIPT-----"
        PrintCenteredText(e.Graphics, labelResto.Text, New Font("Open Sans", 40), Brushes.Black, pageWidth / 2, yPosition)
        yPosition += lineHeight * 2
        PrintCenteredText(e.Graphics, LabelTanggal.Text, printFont, Brushes.Black, pageWidth, yPosition)
        yPosition += lineHeight * 2
        PrintCenteredText(e.Graphics, Label2.Text, printFont, Brushes.Black, 15, yPosition)
        yPosition += lineHeight
        PrintCenteredText(e.Graphics, LabelNamaPelayan.Text, printFont, Brushes.Black, 15, yPosition)
        yPosition += lineHeight * 4
        For Each kvp As KeyValuePair(Of String, Integer) In countDictionary
            Dim labelbarang As New Label()

            labelbarang.Size = New Size(300, 30)
            labelbarang.AutoSize = False
            labelbarang.TextAlign = ContentAlignment.MiddleLeft
            labelbarang.Padding = New Padding(0, 0, 10, 0)

            Dim parts() As String = kvp.Key.Split("|"c)
            If parts.Length = 3 Then
                labelbarang.Text = $"{parts(1).Trim()} - Rp. {parts(2).Trim()} - QTY. {kvp.Value}"
            End If
            PrintCenteredText(e.Graphics, labelbarang.Text, printFont, Brushes.Black, 15, yPosition)
            yPosition += lineHeight
        Next
        PrintCenteredText(e.Graphics, lblTotal.Text, printFont, Brushes.Black, 15, yPosition)
        yPosition += lineHeight
        PrintCenteredText(e.Graphics, lblUang.Text, printFont, Brushes.Black, 15, yPosition)
        yPosition += lineHeight
        PrintCenteredText(e.Graphics, lblKembalian.Text, printFont, Brushes.Black, 15, yPosition)
        yPosition += lineHeight * 13
        PrintCenteredText(e.Graphics, Label3.Text, printFont, Brushes.Black, 15, yPosition)
        yPosition += lineHeight
        PrintCenteredText(e.Graphics, Label4.Text, printFont, Brushes.Black, 15, yPosition)
        yPosition += lineHeight
        PrintCenteredText(e.Graphics, Label5.Text, printFont, Brushes.Black, 15, yPosition)
    End Sub

    Private Sub PrintCenteredText(graphics As Graphics, text As String, font As Font, brush As Brush, pageWidth As Single, yPosition As Single)
        graphics.DrawString(text, font, brush, pageWidth / 5, yPosition)
    End Sub
End Class