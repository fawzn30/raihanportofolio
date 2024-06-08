
Imports System.Data.SqlClient
Public Class Customer
    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox3.Clear()
        TextBox6.Clear()
        TextBox1.Focus()

    End Sub

    Sub DataBaru()
        TextBox2.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        TextBox3.Clear()
        TextBox6.Clear()
        TextBox2.Focus()
    End Sub

    Sub ketemu()
        On Error Resume Next
        TextBox2.Text = dr.Item("Nama_Customer")
        TextBox3.Text = dr.Item("Alamat")
        TextBox2.Focus()
        If dr("Jenis_Usaha") = "Barang" Then
            RadioButton1.Checked = True '
        Else
            RadioButton2.Checked = True
        End If
    End Sub

    Sub tampilgrid()
        Call Koneksi()
        da = New SqlDataAdapter("select * from TBLCustomer", conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True

    End Sub

    'Sub tampilstatus_user()
    '    Call koneksi()
    '    cmd = New SqlCommand("select distinct status_user from TBLCustomer", conn)
    '    dr = cmd.ExecuteReader
    '    Do While dr.Read
    '        ComboBox1.Items.Add(dr(0))
    '    Loop

    'End Sub

    Sub carikode()
        Call Koneksi()
        cmd = New SqlCommand("select * from TBLCustomer where Kode_Customer='" & TextBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Call tampilgrid()
        Call kosongkan()


    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call carikode()
            If dr.HasRows Then
                Call ketemu()
            Else
                Call DataBaru()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Then
                MsgBox("Kode Harus Diisi")

            End If

            Dim pilihan As String
            If RadioButton1.Checked = True Then
                pilihan = RadioButton1.Text
            Else
                pilihan = RadioButton2.Text
            End If

            Call carikode()
            If Not dr.HasRows Then
                Call Koneksi()
                Dim simpan As String = "insert into TBLCustomer values ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "', '" & pilihan & "')"

                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call tampilgrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If TextBox1.Text = "" Then
                MsgBox("Kode Harus Diisi")

            End If

            Dim pilihan As String
            If RadioButton1.Checked = True Then
                pilihan = RadioButton1.Text
            Else
                pilihan = RadioButton2.Text
            End If

            Call carikode()
            If dr.HasRows Then
                Call Koneksi()
                Dim edit As String = "update TBLCustomer set Nama_Customer='" & TextBox2.Text & "', Alamat='" & TextBox3.Text & "', Jenis_usaha='" & pilihan & "' where Kode_Customer='" & TextBox1.Text & "'"
                cmd = New SqlCommand(edit, conn)
                cmd.ExecuteNonQuery()
                Call kosongkan()
                Call tampilgrid()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        On Error Resume Next
        TextBox1.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        Call carikode()
        If dr.HasRows Then
            Call ketemu()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode Harus Diisi")
            TextBox1.Focus()
            Exit Sub
        End If

        Call carikode()
        If Not dr.HasRows Then
            MsgBox("Kode Tidak Terdaftar")
            Exit Sub
        End If

        If MessageBox.Show("Apakah yakin data dihapus?", "", MessageBoxButtons.YesNo) = vbYes Then
            Call Koneksi()
            Dim hapus As String = "delete from TBLCustomer where Kode_Customer='" & TextBox1.Text & "'"
            cmd = New SqlCommand(hapus, conn)
            cmd.ExecuteNonQuery()
            Call kosongkan()
            Call tampilgrid()
        Else
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
        da = New SqlDataAdapter("select * from TBLCustomer where Nama_Customer like '%" & TextBox6.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True
    End Sub


End Class