Imports MySql.Data.MySqlClient

Public Class Penjualan
    Sub Kodeotomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select No_Jual From t_detailjual where No_Jual in(select max(No_Jual) from t_detailjual) ", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows = 0 Then
            TxtFaktur.Text = "FK-" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()
        End If
        If Not dr.HasRows Then
            TxtFaktur.Text = "FK-" + Date.Now.ToString("yyMMdd") + "00001"
            dr.Close()

        Else
            TxtFaktur.Text = Val(Microsoft.VisualBasic.Right(dr.Item("No_Jual").ToString, 4)) + 1
            If Len(TxtFaktur.Text) = 1 Then
                TxtFaktur.Text = "FK-" + Date.Now.ToString("yyMMdd") + "0000" & TxtFaktur.Text & ""
            ElseIf Len(TxtFaktur.Text) = 2 Then
                TxtFaktur.Text = "FK-" + Date.Now.ToString("yyMMdd") + "000" & TxtFaktur.Text & ""
            ElseIf Len(TxtFaktur.Text) = 3 Then
                TxtFaktur.Text = "FK-" + Date.Now.ToString("yyMMdd") + "00" & TxtFaktur.Text & ""
            ElseIf Len(TxtFaktur.Text) = 4 Then
                TxtFaktur.Text = "FK-" + Date.Now.ToString("yyMMdd") + "0" & TxtFaktur.Text & ""
            End If
            dr.Close()
            conn.Close()
        End If
    End Sub
    Sub LoadData()
        Try
            Call koneksi()
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM t_detailjual", conn)
            Dim ds As New DataSet
            ds.Clear()
            da.Fill(ds, "t_detailjual")
            DataGridView1.DataSource = ds.Tables("t_detailjual") ' set datasource of our gridview
            da.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub TampilKodeMember() 'Menampilkan Data Record Kd_Supplier
        Dim StrSql As String
        Try
            Call koneksi()
            StrSql = "select * from t_member"
            Dim Cmd As New MySqlCommand
            Cmd.CommandText = StrSql
            Cmd.Connection = conn
            dr = Cmd.ExecuteReader
            While (dr.Read())
                TxtMember.Items.Add(dr("Kd_Member"))
            End While
            Cmd.Dispose()
            dr.Close()
            conn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kodeotomatis()
        LoadData()
        TampilKodeMember()
        TxtCari.Focus()
    End Sub
    Function caridata(ByVal txt As String)
        Call koneksi()
        Dim cmd2 As New MySqlCommand
        cmd2.Connection = conn
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "select * from t_barang where Kd_Barang like '%" & Trim(txt) & "%' or Nama_Barang like '%" & Trim(txt) & "%'"
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
                    TxtCari.Clear()
                    Lb_KodeBarang.Text = dr2("Kd_Barang")
                    TxtCari.Text = dr2("Nama_Barang")
                    Lb_Stok.Text = dr2("Stok")
                    Lb_Harga.Text = dr2("Harga")
                    TxtQty.Focus()
                    'LB_Harga.Text = dr2("Harga")
                Else
                    MsgBox("data tidak ditemukan!")
                End If
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
    End Sub
    Private Sub Clear()
        TxtMember.Items.Clear()
        TampilKodeMember()
        DateTimePicker1.Value = Now
        TxtTotal.Text = "Rp. 0.00"
        TxtQty.Text = "0"
        TxtKembali.Text = "0"
        TxtBayar.Text = "0"
        TxtFaktur.Clear()
        TxtCari.Clear()
        Kodeotomatis()
    End Sub
    Private Sub InsertPenjualan()
        Try
            If TxtFaktur.Text = "" Then
                MsgBox("Kesalahan dalam Inputan !", MsgBoxStyle.Critical, "Kesalahan")
            Else
                'Dim tanggal As Date = Now
                Call koneksi()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn
                cmd2.CommandType = CommandType.Text
                cmd2.CommandText = "insert into t_detailjual (No_Jual, Kd_Pegawai, Kd_Member, Tanggal, Sub_Total, Diskon, Total, Bayar, Kembalian)values('" & TxtFaktur.Text & "','" & Lb_KdPegawai.Text & "','" & TxtMember.Text & "','" & Format(Now.Date, "yyyy-MM-dd") & "','" & TxtQty.Text & "','" & Lb_Diskon.Text & "','" & Lb_HasilTotal.Text & "','" & LbBayar.Text & "','" & Lb_HasilKembalian.Text & "')"
                cmd2.ExecuteNonQuery()
                MsgBox("Data Berhasil disimpan!")
                conn.Close()
                LoadData()
                UpdateStok()
                Clear()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub UpdateStok()
        Try
            Call koneksi()
            Dim cmd2 As New MySqlCommand
            cmd2.Connection = conn
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "update t_barang set Stok='" & Lb_HasilStok.Text & "' where Kd_Barang='" & Lb_KodeBarang.Text & "'"
            cmd2.ExecuteNonQuery()
            MsgBox("Data Berhasil dirubah!")
            conn.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FBarang.Show()
        FBarang.TopMost = True
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        Me.PictureBox2.BackColor = Color.DarkGreen

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Me.PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Clear()
    End Sub
    Private Sub TxtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQty.KeyPress
        If (e.KeyChar = Chr(13)) Then
            TxtBayar.Focus()
            Try
                Dim total, hasil As Double
                total = Integer.Parse(Lb_Harga.Text) * Integer.Parse(TxtQty.Text)
                hasil = Integer.Parse(Lb_Stok.Text) - Integer.Parse(TxtQty.Text)
                Lb_HasilTotal.Text = total
                TxtTotal.Text = "Rp." + Format(total, "standard")
                Lb_HasilStok.Text = hasil
                BtnDiskon_Click(Me, EventArgs.Empty)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub TxtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBayar.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Try
                Dim kembalian, bayar As Double
                kembalian = Integer.Parse(TxtBayar.Text) - Integer.Parse(Lb_HasilTotal.Text)
                Lb_HasilKembalian.Text = kembalian
                TxtKembali.Text = "Rp." + Format(kembalian, "standard")
                TxtKembali.Focus()
                bayar = Integer.Parse(TxtBayar.Text)
                LbBayar.Text = bayar
                TxtBayar.Text = "Rp." + Format(bayar, "standard")
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        InsertPenjualan()
    End Sub
    Private Sub TxtKembali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKembali.KeyPress
        If (e.KeyChar = Chr(13)) Then
            BtnSave_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub Lb_PesanDiskon_TextChanged(sender As Object, e As EventArgs) Handles Lb_PesanDiskon.TextChanged
        If Me.Lb_PesanDiskon.Text = "Anda Mendapat Discount 20%" Then
            Lb_Diskon.Text = "20%"
        ElseIf Me.Lb_PesanDiskon.Text = "Anda Mendapat Discount 10%" Then
            Lb_Diskon.Text = "10%"
        Else
            Lb_Diskon.Text = "0%"
        End If
    End Sub

    Private Sub Lb_HasilTotal_TextChanged(sender As Object, e As EventArgs) Handles Lb_HasilTotal.TextChanged
        Try
            If Me.Lb_HasilTotal.Text = "0" Then
                Lb_PesanDiskon.Text = ".."
            ElseIf Integer.Parse(Me.Lb_HasilTotal.Text) >= 200000 Then
                Lb_PesanDiskon.Text = "Anda Mendapat Discount 20%"
            ElseIf Integer.Parse(Me.Lb_HasilTotal.Text) < 100000 Then
                Lb_PesanDiskon.Text = "Anda Tidak Mendapatkan Discount"
            ElseIf Integer.Parse(Me.Lb_HasilTotal.Text) >= 100000 Then
                Lb_PesanDiskon.Text = "Anda Mendapat Discount 10%"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDiskon_Click(sender As Object, e As EventArgs) Handles BtnDiskon.Click
        Try
            Dim diskon As Double
            If Me.Lb_HasilTotal.Text = "0" Then
                Lb_PesanDiskon.Text = ".."
            ElseIf Integer.Parse(Me.Lb_HasilTotal.Text) >= 200000 Then
                Lb_PesanDiskon.Text = "Anda Mendapat Discount 20%"
                'Me.TxtTotal.Text = Val(Me.Lb_HasilTotal.Text) - Val((Me.Lb_HasilTotal.Text) * 0.2)
                diskon = (Integer.Parse(Lb_HasilTotal.Text) - Integer.Parse(Lb_HasilTotal.Text) * 0.2)
                TxtTotal.Clear()
                TxtTotal.Text = Format(diskon, "standard")
            ElseIf Integer.Parse(Me.Lb_HasilTotal.Text) < 100000 Then
                Lb_PesanDiskon.Text = "Anda Tidak Mendapatkan Discount"
            ElseIf Integer.Parse(Me.Lb_HasilTotal.Text) >= 100000 Then
                Lb_PesanDiskon.Text = "Anda Mendapat Discount 10%"
                'Me.TxtTotal.Text = Val(Me.Lb_HasilTotal.Text) - Val((Me.Lb_HasilTotal.Text) * 0.1)
                diskon = (Integer.Parse(Lb_HasilTotal.Text) - Integer.Parse(Lb_HasilTotal.Text) * 0.1)
                TxtTotal.Clear()
                TxtTotal.Text = Format(diskon, "standard")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Cetak_Click(sender As Object, e As EventArgs) Handles Btn_Cetak.Click
        Frm_CetakNota.Show()
        Frm_CetakNota.TopMost = True
    End Sub
End Class