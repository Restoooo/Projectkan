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

                CustomMsgBox.Show()
                CustomMsgBox.tableNumber = tableNumber
                clickedButton.BackColor = SystemColors.ButtonHighlight
                'Dim result As DialogResult = MessageBox.Show($"Meja {tableNumber} sedang terkunci. Apakah Anda yakin ingin membukanya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'If result = DialogResult.Yes Then
                'UnlockTable(tableNumber)
                'End If
                btnLoading()
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


    Public Sub UnlockTable(tableNumber As Integer)
        StokModule.lockedTables(tableNumber) = True
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

    Private Sub btnLoading()
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
    Private Sub MenuDuduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLoading()
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

    Private Sub Panel50_Paint(sender As Object, e As PaintEventArgs) Handles Panel50.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel49_Paint(sender As Object, e As PaintEventArgs) Handles Panel49.Paint

    End Sub

    Private Sub ButtonMeja1_Click(sender As Object, e As EventArgs) Handles ButtonMeja1.Click

    End Sub

    Private Sub Panel47_Paint(sender As Object, e As PaintEventArgs) Handles Panel47.Paint

    End Sub

    Private Sub ButtonMeja5_Click(sender As Object, e As EventArgs) Handles ButtonMeja5.Click

    End Sub

    Private Sub Panel46_Paint(sender As Object, e As PaintEventArgs) Handles Panel46.Paint

    End Sub

    Private Sub ButtonMeja6_Click(sender As Object, e As EventArgs) Handles ButtonMeja6.Click

    End Sub

    Private Sub Panel42_Paint(sender As Object, e As PaintEventArgs) Handles Panel42.Paint

    End Sub

    Private Sub ButtonMeja7_Click(sender As Object, e As EventArgs) Handles ButtonMeja7.Click

    End Sub

    Private Sub Panel43_Paint(sender As Object, e As PaintEventArgs) Handles Panel43.Paint

    End Sub

    Private Sub ButtonMeja8_Click(sender As Object, e As EventArgs) Handles ButtonMeja8.Click

    End Sub

    Private Sub Panel44_Paint(sender As Object, e As PaintEventArgs) Handles Panel44.Paint

    End Sub

    Private Sub ButtonMeja3_Click(sender As Object, e As EventArgs) Handles ButtonMeja3.Click

    End Sub

    Private Sub Panel45_Paint(sender As Object, e As PaintEventArgs) Handles Panel45.Paint

    End Sub

    Private Sub ButtonMeja4_Click(sender As Object, e As EventArgs) Handles ButtonMeja4.Click

    End Sub

    Private Sub Panel38_Paint(sender As Object, e As PaintEventArgs) Handles Panel38.Paint

    End Sub

    Private Sub ButtonMeja2_Click(sender As Object, e As EventArgs) Handles ButtonMeja2.Click

    End Sub

    Private Sub Panel34_Paint(sender As Object, e As PaintEventArgs) Handles Panel34.Paint

    End Sub

    Private Sub ButtonMeja9_Click(sender As Object, e As EventArgs) Handles ButtonMeja9.Click

    End Sub

    Private Sub Panel39_Paint(sender As Object, e As PaintEventArgs) Handles Panel39.Paint

    End Sub

    Private Sub ButtonMeja10_Click(sender As Object, e As EventArgs) Handles ButtonMeja10.Click

    End Sub

    Private Sub Panel35_Paint(sender As Object, e As PaintEventArgs) Handles Panel35.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel40_Paint(sender As Object, e As PaintEventArgs) Handles Panel40.Paint

    End Sub

    Private Sub ButtonMeja12_Click(sender As Object, e As EventArgs) Handles ButtonMeja12.Click

    End Sub

    Private Sub Panel41_Paint(sender As Object, e As PaintEventArgs) Handles Panel41.Paint

    End Sub

    Private Sub ButtonMeja13_Click(sender As Object, e As EventArgs) Handles ButtonMeja13.Click

    End Sub

    Private Sub Panel36_Paint(sender As Object, e As PaintEventArgs) Handles Panel36.Paint

    End Sub

    Private Sub ButtonMeja11_Click(sender As Object, e As EventArgs) Handles ButtonMeja11.Click

    End Sub

    Private Sub Panel37_Paint(sender As Object, e As PaintEventArgs) Handles Panel37.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel30_Paint(sender As Object, e As PaintEventArgs) Handles Panel30.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel26_Paint(sender As Object, e As PaintEventArgs) Handles Panel26.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel31_Paint(sender As Object, e As PaintEventArgs) Handles Panel31.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel22_Paint(sender As Object, e As PaintEventArgs) Handles Panel22.Paint

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel32_Paint(sender As Object, e As PaintEventArgs) Handles Panel32.Paint

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Panel33_Paint(sender As Object, e As PaintEventArgs) Handles Panel33.Paint

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Panel18_Paint(sender As Object, e As PaintEventArgs) Handles Panel18.Paint

    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Panel11.Paint

    End Sub

    Private Sub Panel28_Paint(sender As Object, e As PaintEventArgs) Handles Panel28.Paint

    End Sub

    Private Sub Panel17_Paint(sender As Object, e As PaintEventArgs) Handles Panel17.Paint

    End Sub

    Private Sub Panel29_Paint(sender As Object, e As PaintEventArgs) Handles Panel29.Paint

    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel23_Paint(sender As Object, e As PaintEventArgs) Handles Panel23.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Panel15_Paint(sender As Object, e As PaintEventArgs) Handles Panel15.Paint

    End Sub

    Private Sub Panel24_Paint(sender As Object, e As PaintEventArgs) Handles Panel24.Paint

    End Sub

    Private Sub Panel21_Paint(sender As Object, e As PaintEventArgs) Handles Panel21.Paint

    End Sub

    Private Sub Panel25_Paint(sender As Object, e As PaintEventArgs) Handles Panel25.Paint

    End Sub

    Private Sub Panel20_Paint(sender As Object, e As PaintEventArgs) Handles Panel20.Paint

    End Sub

    Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub
End Class


