Imports MySql.Data.MySqlClient

Public Class MenuDuduk

    Public Shared selectedButtons As New List(Of Button)
    Private buttonClicked As Boolean = False
    Public Shared meja As Integer
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

    Private Sub HandleButtonClick(sender As Object, mouse As MouseEventArgs) Handles ButtonMeja1.MouseClick, ButtonMeja2.MouseClick, ButtonMeja3.MouseClick, ButtonMeja4.MouseClick, ButtonMeja5.MouseClick, ButtonMeja6.MouseClick, ButtonMeja7.MouseClick, ButtonMeja8.MouseClick, ButtonMeja9.MouseClick, ButtonMeja10.MouseClick, ButtonMeja11.MouseClick, ButtonMeja12.MouseClick, ButtonMeja13.MouseClick
        Dim clickedButton As Button = DirectCast(sender, Button)
        Dim tableNumber As Integer = Integer.Parse(clickedButton.Text)
        If mouse.Button = MouseButtons.Left Then
            If StokModule.lockedTables(tableNumber) = False Then
                Dim result As DialogResult = MessageBox.Show($"Meja {tableNumber} sedang terkunci. Apakah Anda yakin ingin membukanya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    UnlockTable(tableNumber)
                    clickedButton.BackColor = SystemColors.ButtonHighlight
                End If
            Else
                If selectedButtons.Contains(clickedButton) Then
                    clickedButton.BackColor = SystemColors.ButtonHighlight
                    selectedButtons.Remove(clickedButton)
                    UpdateLabel("")
                Else
                    For Each btn In selectedButtons
                        btn.BackColor = SystemColors.ButtonHighlight
                    Next
                    selectedButtons.Clear()
                    clickedButton.BackColor = SystemColors.ActiveCaption
                    selectedButtons.Add(clickedButton)
                    UpdateLabel(clickedButton.Text)
                End If
            End If
        End If
    End Sub


    Private Sub UnlockTable(tableNumber As Integer)
        StokModule.lockedTables(tableNumber) = False
        Using conn As New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
            conn.Open()
            Dim query As String = "UPDATE tempat_duduk SET status = @status WHERE nomor_meja = @meja"
            Dim cmdUpdateDuduk As New MySqlCommand(query, conn)
            cmdUpdateDuduk.Parameters.AddWithValue("@status", "Tersedia")
            cmdUpdateDuduk.Parameters.AddWithValue("@meja", tableNumber)
            Dim reader As MySqlDataReader = cmdUpdateDuduk.ExecuteReader()
            reader.Close()
        End Using
    End Sub

    Private Sub UpdateLabel(clickedButtonText As String)
        LabelNomorMeja.Text = "Nomor Meja : " & clickedButtonText
        If clickedButtonText = "" Then
            meja = 0
        Else
            meja = Integer.Parse(clickedButtonText)
        End If
    End Sub

    Private Sub ButtonShowMenu_Click(sender As Object, e As EventArgs) Handles ButtonShowMenu.Click
        Dim menuForm As New MenuMakan()
        menuForm.InitializeMenuMakanMinum()
        menuForm.UpdatePanePesanan()
        menuForm.Show()
        Me.Hide()
    End Sub

    Private Sub MenuDuduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In PanelMenuDudukTop.Controls
            If TypeOf ctrl Is Button Then
                Dim button As Button = DirectCast(ctrl, Button)
                Dim tableNumber As Integer = Integer.Parse(button.Text)
                If StokModule.lockedTables.ContainsKey(tableNumber) AndAlso Not StokModule.lockedTables(tableNumber) Then
                    button.BackColor = SystemColors.ActiveCaption
                Else
                    button.BackColor = SystemColors.ButtonHighlight
                End If
            End If
        Next

    End Sub
    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then

            Dim result As DialogResult = MessageBox.Show("Anda yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If result = DialogResult.Yes Then

                Application.Exit()
            Else

                e.Cancel = True
            End If
        End If
    End Sub
End Class


