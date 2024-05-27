Public Class CustomMsgBox
    Public Shared tableNumber As Integer
    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        MenuDuduk.UnlockTable(tableNumber)
        Me.Hide()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        MenuDuduk.meja = tableNumber
        Me.Hide()
        MenuDuduk.Hide()
        MenuMakan.Show()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Hide()
    End Sub

End Class