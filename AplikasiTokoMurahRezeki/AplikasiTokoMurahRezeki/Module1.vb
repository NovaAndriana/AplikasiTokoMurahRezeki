Imports MySql.Data.MySqlClient

Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub koneksi()
        Try
            'string.Format("Server=44.55.110.59; database={0}; UID=root; password=Newuser@123; SslMode = none", databaseName);
            Dim str As String = "Server=localhost;user id=root;password=;SslMode=none;database=db_penjualan"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("sukses")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
