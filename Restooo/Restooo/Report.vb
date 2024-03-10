Imports MySql.Data.MySqlClient

Public Class Report
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles ButtonDashboard.Click
        Dashboard.Show()
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
        Status.TimerStatus.Stop()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT id_pesanan, karyawan.nama, tanggal_pesanan, nomor_meja, harga FROM pesanan INNER JOIN karyawan ON pesanan.id_karyawan = karyawan.id_karyawan", conn)

        adapter.Fill(table)
        DataGridViewReport.DataSource = table
        Dim buttonColumn As New DataGridViewButtonColumn()
        'buttonColumn.HeaderText = "Aksi"
        'buttonColumn.Text = "Detail"
        'buttonColumn.UseColumnTextForButtonValue = True
        'DataGridViewReport.Columns.Add(buttonColumn)
        conn.Close()
    End Sub
    Private Sub DataGridViewReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewReport.CellClick
        Try
            conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
            conn.Open()
            Dim idPesanan As Integer = CInt(DataGridViewReport.Rows(e.RowIndex).Cells("id_pesanan").Value)
            Dim detailTable As New DataTable()
            Dim detailAdapter As New MySqlDataAdapter("SELECT id_pesanan, menu.Nama as Nama, jumlah_pesanan as Jumlah FROM detail_pesanan INNER JOIN menu on detail_pesanan.id_menu = menu.id_menu  WHERE id_pesanan = @id_pesanan", conn)
            detailAdapter.SelectCommand.Parameters.AddWithValue("@id_pesanan", idPesanan)
            detailAdapter.Fill(detailTable)
            DataGridViewReportDetail.DataSource = detailTable
            conn.Close()
        Catch
        End Try
    End Sub

    Private Sub LoadData()
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT id_pesanan, karyawan.nama, tanggal_pesanan, nomor_meja, harga FROM pesanan INNER JOIN karyawan ON pesanan.id_karyawan = karyawan.id_karyawan", conn)

        adapter.Fill(table)
        DataGridViewReport.DataSource = table
        conn.Close()
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        LoadData()
    End Sub
End Class