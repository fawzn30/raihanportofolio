Imports System.Data.SqlClient 'inget namespace wajib


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi() 'connect ke database
        da = New SqlDataAdapter("select * from TBlbarang", conn) 'minta data dari tabel tertentu
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True

        'format ribuan
        dgv.Columns(3).DefaultCellStyle.Format = "#,0"

        'format angka ke kanan
        dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'jumlah record dalam dgv
        TextBox8.Text = dgv.RowCount - 1

        'total stok
        Call hitungstok()

        'warna dgv
        dgv.RowsDefaultCellStyle.BackColor = Color.LimeGreen
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.OrangeRed

    End Sub

    'DISARANKAN BIKIN SUB AGAR PEKERJAAN LEBIH EFISIEN
    Sub hitungstok()
        Dim x As Integer
        Dim y As Integer
        For baris As Integer = 0 To dgv.RowCount - 1
            x = x + dgv.Rows(baris).Cells(5).Value
            y = y + dgv.Rows(baris).Cells(4).Value
            'cara hitung total barang/stok
            '0=0+10
            '10=10+50
            '60=60+10
            '70=70+20
            '90=90+20 = 110
            TextBox9.Text = x
            TextBox10.Text = y
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() 'bikin program muncul di tengahh layar
        Call Koneksi()
        cmd = New SqlCommand("select * from TBlbarang", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ListBox1.Items.Add(dr(0))
            ComboBox1.Items.Add(dr("nama_barang"))
        Loop

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Call Koneksi()
        cmd = New SqlCommand("select * from TBlbarang where kode_barang='" & ListBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr("kode_barang")
            TextBox2.Text = dr("nama_barang")
            TextBox3.Text = dr("satuan")
            TextBox4.Text = dr("harga_beli")
            TextBox5.Text = dr("harga_jual")
            TextBox6.Text = dr("stok")
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Call Koneksi()
        da = New SqlDataAdapter("select * from TBlbarang where nama_barang like '%" & TextBox7.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True
    End Sub

    'hapus data dalam dgv dengan KeyDown
    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Delete Then
            dgv.Rows.Remove(dgv.CurrentRow)
            Call hitungstok()
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        TextBox1.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = dgv.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = dgv.Rows(e.RowIndex).Cells(4).Value
        TextBox6.Text = dgv.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") And e.KeyChar <> vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.Focus()

        End If
    End Sub
End Class
