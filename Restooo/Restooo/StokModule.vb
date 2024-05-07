Imports MySql.Data.MySqlClient

Public Class StokModule
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Public Shared jumlahMenuChecker As New Dictionary(Of Integer, Integer)()
    Public Shared lockedTables As New Dictionary(Of Integer, Boolean)()


    Public Sub InitializeMenu()
        conn = New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
        conn.Open()
        cmd = New MySqlCommand("SELECT id_menu, stok FROM Menu", conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        jumlahMenuChecker.Clear()
        While reader.Read()
            Dim idMenu As Integer = Convert.ToInt32(reader("id_menu"))
            Dim stok As Integer = Convert.ToInt32(reader("stok"))
            jumlahMenuChecker.Add(idMenu, stok)
        End While
        reader.Close()
        conn.Close()
    End Sub

    Public Sub InitializeLockedTables()

        Using conn As New MySqlConnection("server=localhost;database=restoooo;user=root;password=")
            conn.Open()

            Dim query As String = "SELECT nomor_meja,status FROM tempat_duduk"
            Dim cmdSelect As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmdSelect.ExecuteReader()

            While reader.Read()
                Dim tableNumber As Integer = reader.GetInt32(0)
                Dim status As String = reader.GetString("status")
                If status = "Tersedia" Then
                    lockedTables(tableNumber) = True
                Else
                    lockedTables(tableNumber) = False
                End If
            End While

            reader.Close()
        End Using
    End Sub


End Class
