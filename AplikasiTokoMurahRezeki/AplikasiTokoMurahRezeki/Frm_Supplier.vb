Imports MySql.Data.MySqlClient

Public Class Frm_Supplier
    Sub Clear()
        TxtCari.Clear()
        TxtNoTelp.Clear()
        TxtAlamat.Clear()
        TxtNama.Clear()
        LoadData()
        Kodeotomatis()
    End Sub
    Sub Kodeotomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select Kd_Supplier From t_supplier where Kd_Supplier in(select max(Kd_Supplier) from t_supplier) ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = 0 Then
            TxtKode.Text = "SP" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()
        End If
        If Not dr.HasRows Then
            TxtKode.Text = "SP" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()

        Else
            TxtKode.Text = Val(Microsoft.VisualBasic.Right(dr.Item("Kd_Supplier").ToString, 4)) + 1
            If Len(TxtKode.Text) = 1 Then
                TxtKode.Text = "SP" + Date.Now.ToString("yyMMdd") + "0000" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 2 Then
                TxtKode.Text = "SP" + Date.Now.ToString("yyMMdd") + "000" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 3 Then
                TxtKode.Text = "SP" + Date.Now.ToString("yyMMdd") + "00" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 4 Then
                TxtKode.Text = "SP" + Date.Now.ToString("yyMMdd") + "0" & TxtKode.Text & ""
            End If
            dr.Close()
            conn.Close()
        End If
    End Sub

    Sub LoadData()

        Try
            Call koneksi()
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM t_supplier", conn)
            Dim ds As New DataSet
            ds.Clear()
            da.Fill(ds, "t_supplier")
            DataGridView1.DataSource = ds.Tables("t_supplier") ' set datasource of our gridview
            da.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            If TxtKode.Text = "" Or TxtNama.Text = "" Then
                MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "insert into t_supplier(Kd_Supplier, Nama_Supplier, Alamat, No_Telp)values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtAlamat.Text & "','" & TxtNoTelp.Text & "')"
                cmd2.ExecuteNonQuery()
                MsgBox("Data Berhasil disimpan!")
                conn.Close()
                LoadData()
                Clear()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear()
    End Sub

    Private Sub Frm_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Kodeotomatis()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            If TxtKode.Text = "" Or TxtNama.Text = "" Then
                MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "update t_supplier set Nama_Supplier='" & TxtNama.Text & "',Alamat='" & TxtAlamat.Text & "',No_Telp='" & TxtNoTelp.Text & "' where Kd_Supplier='" & TxtKode.Text & "'"
                cmd2.ExecuteNonQuery()
                MsgBox("Data Berhasil dirubah!")
                conn.Close()
                LoadData()
                Clear()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            If TxtKode.Text = "" Or TxtNama.Text = "" Then
                MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "delete from t_supplier where Kd_Supplier='" & TxtKode.Text & "'"
                cmd2.ExecuteNonQuery()
                MsgBox("Data Berhasil dihapus!")
                conn.Close()
                LoadData()
                Clear()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Function caridata(ByVal txt As String)
        Call koneksi()
        Dim cmd2 As New MySqlCommand
        cmd2.Connection = conn
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "select * from t_supplier where Kd_Supplier='" & Trim(txt) & "'"
        caridata = cmd2
    End Function
    Private Sub TxtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCari.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Try
                conn.Close()
                Call koneksi()
                Dim cari = caridata(TxtCari.Text)
                Dim dr2 As MySqlDataReader
                dr2 = cari.ExecuteReader
                If dr2.HasRows = True Then
                    dr2.Read()
                    TxtKode.Text = dr2("Kd_Supplier")
                    TxtNama.Text = dr2("Nama_Supplier")
                    TxtAlamat.Text = dr2("Alamat")
                    TxtNoTelp.Text = dr2("No_Telp")
                Else
                    MsgBox("data tidak ditemukan!")
                End If
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            TxtKode.Text = DataGridView1.Item(0, i).Value
            TxtNama.Text = DataGridView1.Item(1, i).Value
            TxtAlamat.Text = DataGridView1.Item(2, i).Value
            TxtNoTelp.Text = DataGridView1.Item(3, i).Value.ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class