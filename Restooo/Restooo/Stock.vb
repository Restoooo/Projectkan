Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Stock

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
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

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load, ButtonStock.Click
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT id_menu, Nama, Stok FROM menu", conn)
        adapter.Fill(table)
        DataGridViewStock.DataSource = table
        conn.Close()
    End Sub

    Private Sub LoadData()
        Dim table As New DataTable()
        Try
            conn.Open()
            Dim adapter As New MySqlDataAdapter("SELECT id_menu, Nama, Stok FROM menu", conn)
            adapter.Fill(table)
            DataGridViewStock.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim id As Integer = CInt(InputBox("Masukkan Menu Id:", "Input"))
        Dim stok As Integer = CInt(InputBox("Masukkan berapa banyak stok:", "Input"))
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        cmd = New MySqlCommand("Update Menu set stok=@stok where id_menu=@id", conn)
        cmd.Parameters.AddWithValue("id", id)
        cmd.Parameters.AddWithValue("stok", stok)
        Try
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Data berhasil diperbarui.")
            Else
                MessageBox.Show("Data tidak ditemukan.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        LoadData() ' Memanggil metode untuk memperbarui DataGridView
    End Sub


End Class