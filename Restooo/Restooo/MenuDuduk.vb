Public Class MenuDuduk

    Public Shared selectedButtons As New List(Of Button)
    Public Shared lockedTables As New Dictionary(Of Integer, Boolean)()
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

    Private Sub InitializeLockedTables()
        For i As Integer = 1 To 13
            lockedTables.Add(i, False)
        Next
    End Sub
    Private Sub HandleButtonClick(sender As Object, mouse As MouseEventArgs) Handles ButtonMeja1.MouseClick, ButtonMeja2.MouseClick, ButtonMeja3.MouseClick, ButtonMeja4.MouseClick, ButtonMeja5.MouseClick, ButtonMeja6.MouseClick, ButtonMeja7.MouseClick, ButtonMeja8.MouseClick, ButtonMeja9.MouseClick, ButtonMeja10.MouseClick, ButtonMeja11.MouseClick, ButtonMeja12.MouseClick, ButtonMeja13.MouseClick
        Dim clickedButton As Button = DirectCast(sender, Button)
        Dim tableNumber As Integer = Integer.Parse(clickedButton.Text)

        If mouse.Button = MouseButtons.Left Then
            If lockedTables(tableNumber) Then
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
        lockedTables(tableNumber) = False

    End Sub
    Private Sub MenuDuduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeLockedTables()
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


End Class


