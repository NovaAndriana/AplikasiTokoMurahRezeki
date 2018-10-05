Public Class Menu_Utama
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim n As String = MsgBox("Apa anda yakin ingin keluar?", MsgBoxStyle.YesNo, "Confirmation Dialog Box")
        If n = vbYes Then
            MsgBox("Mohon menunggu....")
            Me.Close() 'Current Form Closed
            Frm_Login.Show() 'Form Name.show()
        End If
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FBarang.Show()
        FBarang.TopMost = True
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Frm_Supplier.Show()
        Frm_Supplier.TopMost = True
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        FrmPegawai.Show()
        FrmPegawai.TopMost = True
    End Sub

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        Frm_Member.Show()
        Frm_Member.TopMost = True
    End Sub

    Private Sub PemberianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemberianToolStripMenuItem.Click
        Frm_LapPembelian.Show()
        Frm_LapPembelian.TopMost = True
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Penjualan.Show()
        Penjualan.TopMost = True
        Penjualan.Lb_KdPegawai.Text = Me.Lb_kdPegawai.Text
        Penjualan.TxtCari.Focus()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
        AboutBox1.TopMost = True
    End Sub

    Private Sub LapBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapBarangToolStripMenuItem.Click
        Frm_LapBarang.Show()
        Frm_LapBarang.TopMost = True
    End Sub

    Private Sub LapPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapPegawaiToolStripMenuItem.Click
        Frm_LapPegawai.Show()
        Frm_LapPegawai.TopMost = True
    End Sub

    Private Sub LapPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapPenjualanToolStripMenuItem.Click
        Frm_LapPenjualan.Show()
        Frm_LapPenjualan.TopMost = True
    End Sub

    Private Sub LapPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LapPembelianToolStripMenuItem.Click
        FrmLaporanPembelian.Show()
        FrmLaporanPembelian.TopMost = True
    End Sub
End Class