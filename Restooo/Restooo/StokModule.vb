Imports MySql.Data.MySqlClient

Public Class StokModule
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public Shared jumlahMenuChecker As New Dictionary(Of Integer, Integer)()

    Public Sub InitializeMenu()
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        cmd = New MySqlCommand("SELECT id_menu, stok FROM Menu where jenis = 'makanan'", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        jumlahMenuChecker.Clear()
        While reader.Read()
            Dim idMenu As Integer = Convert.ToInt32(reader("id_menu"))
            Dim stok As Integer = Convert.ToInt32(reader("stok"))
            jumlahMenuChecker.Add(idMenu, stok)
        End While
        conn.Close()
    End Sub
End Class
