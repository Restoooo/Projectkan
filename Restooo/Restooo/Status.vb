Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Status


    Public Shared WaktuOnline As TimeSpan = TimeSpan.Zero


    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        Dashboard.Show()
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
        Login.Show()
        Me.Hide()
    End Sub


    Private Sub TimerStatus_Tick(sender As Object, e As EventArgs) Handles TimerStatus.Tick
        WaktuOnline = WaktuOnline.Add(TimeSpan.FromSeconds(1))
        labelTimer.Text = WaktuOnline.ToString
    End Sub

    Private Sub Status_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then

            Dim result As DialogResult = MessageBox.Show("Anda yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If result = DialogResult.Yes Then

                Application.Exit()
            Else

                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load, ButtonStatus.Click
        txtName.Text = "Name: " + Login.NamaKaryawan
        txtUsername.Text = "Username: " + Login.Username
        Dim conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        Dim tgl = Date.Today
        Dim formattedDate As String = tgl.ToString("yyyy-MM-dd")
        Dim queery As String = $"SELECT COUNT(*) FROM pesanan where id_karyawan = {Login.idAkun} And tanggal_pesanan = '{formattedDate}'"
        Dim cmd = New MySqlCommand(queery, conn)
        MessageBox.Show(queery)
        Dim Reader = cmd.ExecuteReader()
        If Reader.Read() Then
            Dim pesananCount As Integer = Reader.GetInt32(0)
            LabelPesanan.Text = "Pesanan: " & pesananCount
        End If
    End Sub
End Class