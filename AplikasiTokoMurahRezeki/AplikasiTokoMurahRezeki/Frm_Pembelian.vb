Imports MySql.Data.MySqlClient

Public Class Frm_LapPembelian
    Sub Clear()
        TxtCari.Clear()
        TxtJumlah.Clear()
        TxtHarga.Clear()
        TxtKodeBarang.Clear()
        LoadData()
        Kodeotomatis()
    End Sub
    Sub Kodeotomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select No_Beli From t_beli where No_Beli in(select max(No_Beli) from t_beli) ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = 0 Then
            TxtKode.Text = "BL/" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()
        End If
        If Not dr.HasRows Then
            TxtKode.Text = "BL/" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()

        Else
            TxtKode.Text = Val(Microsoft.VisualBasic.Right(dr.Item("No_Beli").ToString, 4)) + 1
            If Len(TxtKode.Text) = 1 Then
                TxtKode.Text = "BL/" + Date.Now.ToString("yyMMdd") + "0000" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 2 Then
                TxtKode.Text = "BL/" + Date.Now.ToString("yyMMdd") + "000" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 3 Then
                TxtKode.Text = "BL/" + Date.Now.ToString("yyMMdd") + "00" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 4 Then
                TxtKode.Text = "BL/" + Date.Now.ToString("yyMMdd") + "0" & TxtKode.Text & ""
            End If
            dr.Close()
            conn.Close()
        End If
    End Sub
    Sub LoadData()
        Try
            Call koneksi()
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM t_beli", conn)
            Dim ds As New DataSet
            ds.Clear()
            da.Fill(ds, "t_beli")
            DataGridView1.DataSource = ds.Tables("t_beli") ' set datasource of our gridview
            da.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub Frm_Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Kodeotomatis()
        TampilKodeSupplier()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clear()
        Me.Close()
    End Sub
    Private Sub InsertDetailBeli()
        Try
            If TxtKode.Text = "" Or TxtKodeSupplier.Text = "" Then
                MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "insert into t_detailbeli (No_Beli, Kd_Barang, Jumlah, Harga)values('" & TxtKode.Text & "','" & TxtKodeBarang.Text & "','" & TxtJumlah.Text & "','" & TxtHarga.Text & "')"
                cmd2.ExecuteNonQuery()
                MsgBox("Data Berhasil disimpan!")
                conn.Close()
                'LoadData()
                Clear()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub InsertBeli()
        Try
            If TxtKode.Text = "" Or TxtKodeSupplier.Text = "" Then
                MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                Dim tanggal As Date = Now
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "insert into t_beli (No_Beli, Kd_Supplier, Kd_Pegawai, Tanggal, Total)values('" & TxtKode.Text & "','" & TxtKodeSupplier.Text & "','" & Menu_Utama.Lb_kdPegawai.Text & "','" & tanggal.ToString & "','" & LB_Total.Text & "')"
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

    Private Sub TxtHarga_TextChanged(sender As Object, e As EventArgs) Handles TxtHarga.TextChanged
        Try
            Dim total As Double

            total = Integer.Parse(TxtHarga.Text) * Integer.Parse(TxtJumlah.Text)
            LB_Total.Text = total.ToString
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles TxtJumlah.TextChanged
        Try
            Dim total As Double
            Dim stok As Double
            total = Integer.Parse(TxtHarga.Text) * Integer.Parse(TxtJumlah.Text)
            LB_Total.Text = total.ToString
            stok = Integer.Parse(TxtJumlah.Text) + Integer.Parse(LB_Stok.Text)
            LB_JumlahStok.Text = stok.ToString
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub
    Sub TampilKodeSupplier() 'Menampilkan Data Record Kd_Supplier
        Dim StrSql As String
        Try
            Call koneksi()
            StrSql = "select * from t_supplier"
            Dim Cmd As New MySqlCommand
            Cmd.CommandText = StrSql
            Cmd.Connection = conn
            dr = Cmd.ExecuteReader
            While (dr.Read())
                TxtKodeSupplier.Items.Add(dr("Kd_Supplier"))
            End While
            Cmd.Dispose()
            dr.Close()
            conn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Function caridata(ByVal txt As String)
        Call koneksi()
        Dim cmd2 As New MySqlCommand
        cmd2.Connection = conn
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "select Kd_Barang, Stok, Harga from t_barang where Kd_Barang='" & Trim(txt) & "'"
        caridata = cmd2
    End Function

    Private Sub TxtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeBarang.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Try
                conn.Close()
                Call koneksi()
                Dim cari = caridata(TxtKodeBarang.Text)
                Dim dr2 As MySqlDataReader
                dr2 = cari.ExecuteReader
                If dr2.HasRows = True Then
                    dr2.Read()
                    TxtKodeBarang.Text = dr2("Kd_Barang")
                    LB_Stok.Text = dr2("Stok")
                    LB_Harga.Text = dr2("Harga")
                    'BtnHapus.Enabled = False
                    BtnUpdate.Enabled = True
                    BtnUpdate.Text = "Update"
                    TxtHarga.Focus()
                Else
                    MsgBox("data tidak ditemukan!")
                    BtnUpdate.Text = "Save"
                End If
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        InsertDetailBeli()
        InsertBeli()
        Try
            Call koneksi()
            Dim cmd2 As New MySqlCommand
            cmd2.Connection = conn
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "update t_barang set Stok='" & LB_JumlahStok.Text & "' where Kd_Barang='" & TxtKodeBarang.Text & "'"
            cmd2.ExecuteNonQuery()
            MsgBox("Data Berhasil dirubah!")
            conn.Close()
            LoadData()
            Clear()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        FBarang.Show()
    End Sub

    Private Sub LB_Total_TextChanged(sender As Object, e As EventArgs) Handles LB_Total.TextChanged
        Try
            Dim hasil As Double
            hasil = Integer.Parse(LB_Total.Text) + Integer.Parse(LB_Harga.Text)
            LB_HasilTotal.Text = hasil.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class