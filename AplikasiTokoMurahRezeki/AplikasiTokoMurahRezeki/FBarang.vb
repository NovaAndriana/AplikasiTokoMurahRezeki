Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class FBarang
    Sub Clear()
        TxtCari.Clear()
        TxtHarga.Clear()
        TxtJumlah.Clear()
        TxtNama.Clear()
        LoadData()
        Kodeotomatis()
    End Sub
    Sub Kodeotomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select Kd_Barang From t_barang where Kd_Barang in(select max(Kd_Barang) from t_barang) ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = 0 Then
            TxtKode.Text = "BR" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()
        End If
        If Not dr.HasRows Then
            TxtKode.Text = "BR" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()

        Else
            TxtKode.Text = Val(Microsoft.VisualBasic.Right(dr.Item("Kd_Barang").ToString, 4)) + 1
            If Len(TxtKode.Text) = 1 Then
                TxtKode.Text = "BR" + Date.Now.ToString("yyMMdd") + "0000" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 2 Then
                TxtKode.Text = "BR" + Date.Now.ToString("yyMMdd") + "000" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 3 Then
                TxtKode.Text = "BR" + Date.Now.ToString("yyMMdd") + "00" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 4 Then
                TxtKode.Text = "BR" + Date.Now.ToString("yyMMdd") + "0" & TxtKode.Text & ""
            End If
            dr.Close()
            conn.Close()
        End If
    End Sub

    Sub LoadData()

        Try
            Call koneksi()
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM t_barang", conn)
            Dim ds As New DataSet
            ds.Clear()
            da.Fill(ds, "t_barang")
            DataGridView1.DataSource = ds.Tables("t_barang") ' set datasource of our gridview
            da.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear()
    End Sub

    Private Sub FBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Kodeotomatis()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            TxtKode.Text = DataGridView1.Item(0, i).Value
            TxtNama.Text = DataGridView1.Item(1, i).Value
            TxtJumlah.Text = DataGridView1.Item(2, i).Value
            TxtHarga.Text = DataGridView1.Item(3, i).Value.ToString
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Function caridata(ByVal txt As String)
        Call koneksi()
        Dim cmd2 As New MySqlCommand
        cmd2.Connection = conn
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "select * from t_barang where Kd_Barang='" & Trim(txt) & "'"
        caridata = cmd2
    End Function
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Try
            If TxtKode.Text = "" Or TxtNama.Text = "" Then
                MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "insert into t_barang(Kd_Barang, Nama_Barang, Stok, Harga)values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & TxtJumlah.Text & "','" & TxtHarga.Text & "')"
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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            If TxtKode.Text = "" Or TxtNama.Text = "" Then
                MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "update t_barang set Nama_Barang='" & TxtNama.Text & "',Stok='" & TxtJumlah.Text & "',Harga='" & TxtHarga.Text & "' where Kd_Barang='" & TxtKode.Text & "'"
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
                cmd2.CommandText = "delete from t_barang where Kd_Barang='" & TxtKode.Text & "'"
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

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged

    End Sub

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
                    TxtKode.Text = dr2("Kd_Barang")
                    TxtNama.Text = dr2("Nama_Barang")
                    TxtJumlah.Text = dr2("Stok")
                    TxtHarga.Text = dr2("Harga")
                Else
                    MsgBox("data tidak ditemukan!")
                End If
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class