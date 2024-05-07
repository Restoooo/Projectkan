Public Class Loading
    Dim counter As Integer = 0
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerLoading.Start()
    End Sub

    Private Sub TimerLoading_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick
        If ProgressBarLoading.Value < 100 Then
            ProgressBarLoading.Value += counter
            counter += 20
        End If
        If ProgressBarLoading.Value >= 100 Then

            Dim stokModul As New StokModule()
            stokModul.InitializeMenu()
            stokModul.InitializeLockedTables()


            Status.TimerStatus.Start()
            Me.Close()
            Dashboard.Show()


            TimerLoading.Stop()
        End If
    End Sub

End Class