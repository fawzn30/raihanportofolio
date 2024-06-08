
Imports System.Data.SqlClient

Public Class Barang

    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox1.Focus()
    End Sub
    Sub databaru()
        TextBox2.Clear()
        ComboBox1.Text = ""
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox2.Focus()
    End Sub
    Sub ketemu()
        TextBox2.Text = dr("nama_barang") 'dr(1)
        ComboBox1.Text = dr("satuan") 'dr(2)
        TextBox3.Text = dr("harga_beli")
        TextBox4.Text = dr("harga_jual")
        TextBox5.Text = dr("stok")
        TextBox2.Focus()
    End Sub
    Sub tampilgrid()
        Call Koneksi()
        da = New SqlDataAdapter("select * from TBLBarang", conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True
    End Sub
    Sub tampilsatuan()
        Call Koneksi()
        cmd = New SqlCommand("select distinct satuan from TBLBarang", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr(0))
        Loop
    End Sub
    Sub carikode()
        Call Koneksi()
        cmd = New SqlCommand("select * from TBLBarang where kode_barang='" & TextBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() 'ketengahkan
        Call tampilgrid()
        Call tampilsatuan()
        Call kosongkan()

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call carikode()
            If dr.HasRows Then
                Call ketemu()
            Else 'jika data tidak ada
                Call databaru()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call carikode()
            If Not dr.HasRows Then
                Dim simpan As String = "insert into TBLBarang values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call tampilgrid()
                Call tampilsatuan()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick

        On Error Resume Next
        'textbox1 diisi kode diambil dari dgv
        TextBox1.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Call carikode()
            If dr.HasRows Then
                Call Koneksi()
                Dim edit As String = "update TBLBarang set nama_barang='" & TextBox2.Text & "',satuan='" & ComboBox1.Text & "',harga_beli='" & TextBox3.Text & "',harga_jual='" & TextBox4.Text & "',stok='" & TextBox5.Text & "' where kode_Barang='" & TextBox1.Text & "'"
                cmd = New SqlCommand(edit, conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call tampilgrid()
                Call tampilsatuan()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("kode Barang harus diisi dulu")
            Exit Sub
        End If

        Call carikode()
        If Not dr.HasRows Then 'jika kode tidak ada di tabel
            MsgBox("kode tidak terdaftar")
            TextBox1.Focus()
            Exit Sub
        End If

        'jika kode sdh diisi dan kodenyaada ditabel...
        If MessageBox.Show("yakin akan dihapus ...?", "", MessageBoxButtons.YesNo) = vbYes Then
            Call Koneksi()
            Dim hapus As String = "delete from TBLBarang where kode_barang='" & TextBox1.Text & "'"
            cmd = New SqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            Call kosongkan()
            Call tampilgrid()
            Call tampilsatuan()
        Else 'jika dijawab NO
            Call kosongkan()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call kosongkan()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Call Koneksi()
        da = New SqlDataAdapter("select * from TBLBarang where nama_barang like '%" & TextBox6.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True

    End Sub
End Class


