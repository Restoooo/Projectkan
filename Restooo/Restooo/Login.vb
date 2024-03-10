Imports MySql.Data.MySqlClient

Public Class Login

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public Shared idAkun As Integer
    Public Shared NamaKaryawan As String
    Public Shared Jabatan As String
    Public Shared Username As String

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.BackColor = Color.WhiteSmoke

        End If
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.BackColor = Color.White
        End If
    End Sub

    Private Sub txtPass_LostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus
        If txtPass.Text = "" Then
            txtPass.Text = "Password"
            txtPass.BackColor = Color.White
        End If
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        If txtPass.Text = "Password" Then
            txtPass.Text = ""
            txtPass.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub CbPass_CheckedChanged(sender As Object, e As EventArgs) Handles CbPass.CheckedChanged
        If CbPass.Checked Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ButtonLog_Click(sender As Object, e As EventArgs) Handles ButtonLog.Click
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        cmd = New MySqlCommand("SELECT * FROM karyawan where username=@username AND password=@pass", conn)
        cmd.Parameters.AddWithValue("username", txtUsername.Text.Trim)
        cmd.Parameters.AddWithValue("pass", txtPass.Text.Trim)
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            reader.Read()
            idAkun = reader.GetInt32(0)
            NamaKaryawan = reader.GetString("Nama")
            Jabatan = reader.GetString("Jabatan")
            Username = reader.GetString("Username")
            Dashboard.Show()
            Me.Hide()
        Else
            MsgBox("Error Username or Password")
        End If
        reader.Close()
        Status.TimerStatus.Start()
        conn.Close()
    End Sub

End Class
