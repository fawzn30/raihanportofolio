
Imports System.Data.SqlClient 'namespace wajib'
Public Class Login

    Dim hitung As Integer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Call Koneksi()
        cmd = New SqlCommand("select * from tbluser where nama_user='" & tnama.Text & "' and pwd_user='" & tpassword.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            'case sensitif password
            If tpassword.Text <> dr("pwd_user") Then
                MsgBox("password salah")
                tpassword.Focus()
                Exit Sub
            End If

            Me.Visible = False 'form login disembunyikan
            MenuUtama.Show()
            'SETELAH BERHASIL LOGIN....
            MenuUtama.panel1.Text = dr(0) 'kode
            MenuUtama.panel2.Text = dr(1) 'nama
            MenuUtama.panel1.Text = UCase(dr("status_user"))
            'ucase = mengubah karakter jadi huruf besar semua

            'hak akses 
            'visibled=false =menu  tidak terlihat 
            'enabled=false = menu terlihat tp tdk dpt diklik

            If MenuUtama.panel3.Text <> "ADMIN" Then
                MenuUtama.Button1.Enabled = False
                MenuUtama.UserToolStripMenuItem.Enabled = False
            Else
                MenuUtama.Button1.Enabled = True
                MenuUtama.UserToolStripMenuItem.Enabled = True
            End If
        Else
            MsgBox("login gagal")
            hitung = hitung + 1
            '0=0+1 =1
            '1=1+1 =2
            '2=2+1 =3
            If hitung = 3 Then
                End
            End If
            'tnama.Clear()
            'tpassword.Clear()
            'tnama.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub
End Class
