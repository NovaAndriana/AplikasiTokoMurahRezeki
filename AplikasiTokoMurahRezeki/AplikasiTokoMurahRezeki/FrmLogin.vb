'Imports System.Data.MysqlClient
Public Class Frm_Login
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call koneksi()
    End Sub
    Sub clear()
        Txt_Pass.Clear()
        Txt_Uname.Clear()
        Txt_Uname.Focus()
    End Sub
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Call clear()
        Me.Close()
    End Sub
    Sub login()
        Call koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("select * from t_Pegawai where Kd_Pegawai='" & Txt_Uname.Text & "' and Password='" & Txt_Pass.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub
    Private Sub Btn_Submit_Click(sender As Object, e As EventArgs) Handles Btn_Submit.Click
        Try
            Call login()
            If dr.HasRows Then
                Menu_Utama.Label_Uname.Text = dr.Item("Nama_Pegawai").ToString
                Menu_Utama.Lb_kdPegawai.Text = dr.Item("Kd_Pegawai").ToString
                Call clear()
                Me.Hide()
                conn.Close()
                Menu_Utama.Show()
            Else
                MsgBox("Username/password yang anda masukan salah")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class
