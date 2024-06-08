Imports System.Data.SqlClient

Public Class Penjualan
    Sub faktis()
        Call Koneksi()
        cmd = New SqlCommand("select faktur from tblpenjualan order by faktur desc", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            LFaktur.Text = Format(Today, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(dr.Item("faktur"), 6) = Format(Today, "yyMMdd") Then
                LFaktur.Text = dr.Item("faktur") + 1
            Else
                LFaktur.Text = Format(Today, "yyMMdd") + "0001"
            End If
        End If
    End Sub

    Sub tampilcustomer()
        Call Koneksi()
        cmd = New SqlCommand("Select * from tblcustomer", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr("kode_customer"))
        Loop
    End Sub

    Sub hitungbarang()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To dgv.RowCount - 1
            hitung = hitung + dgv.Rows(baris).Cells(3).Value
        Next
    End Sub

    Sub hitungharga()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To dgv.RowCount - 1
            hitung = hitung + dgv.Rows(baris).Cells(4).Value
        Next
        LTotalHarga.Text = hitung

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        cmd = New SqlCommand("select * from tblcustomer where kode_customer='" & ComboBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Lnamacustomer.Text = dr("nama_customer")
        End If
    End Sub

    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Call bersihkan()
        Call faktis()
        LTanggal.Text = Format(Today, "dd MMMM yyyy")
        Call tampilcustomer()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        On Error Resume Next
        If e.ColumnIndex = 0 Then
            dgv.Rows(e.RowIndex).Cells(0).Value = UCase(dgv.Rows(e.RowIndex).Cells(0).Value)
            For barisatas As Integer = 0 To dgv.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To dgv.RowCount - 1
                    If dgv.Rows(barisbawah).Cells("kode").Value = dgv.Rows(barisatas).Cells("kode").Value Then
                        dgv.Rows(barisatas).Cells("jumlah").Value = dgv.Rows(barisatas).Cells("jumlah").Value + 1
                        dgv.Rows(barisatas).Cells("subtotal").Value = dgv.Rows(barisatas).Cells("Jumlah").Value * dgv.Rows(barisatas).Cells("Harga").Value

                        dgv.Rows.Remove(dgv.CurrentRow)
                        SendKeys.Send("{down}")
                        Call hitungharga()
                        Exit Sub
                    End If
                Next
            Next

            Call Koneksi()
            cmd = New SqlCommand("select * from tblbarang where left(kode_barang, 4)= '" & dgv.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                dgv.Rows(e.RowIndex).Cells(1).Value = dr.Item("nama_barang")

                dgv.Rows(e.RowIndex).Cells(2).Value = FormatNumber(dr("harga_jual"), 0)
                dgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                dgv.Rows(e.RowIndex).Cells(3).Value = 1
                dgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                dgv.Rows(e.RowIndex).Cells(4).Value = dgv.Rows(e.RowIndex).Cells(2).Value * dgv.Rows(e.RowIndex).Cells(3).Value
                dgv.Rows(e.RowIndex).Cells("subtotal").Value = FormatNumber(dgv.Rows(e.RowIndex).Cells("subtotal").Value, 0)
                dgv.Columns("subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            Else
                MsgBox("Kode barang tidak ditemukan")
                SendKeys.Send("{up}")
                dgv.Rows(e.RowIndex).Cells(0).Value = ""
            End If
        End If


        If e.ColumnIndex = 3 Then
            Koneksi()
            cmd = New SqlCommand("select * from tblbarang where left(kode_barang,4)= '" & dgv.Rows(e.RowIndex).Cells("kode").Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dgv.Rows(e.RowIndex).Cells("jumlah").Value > dr("stok") Then
                    MsgBox("stok hanya ada " & dr("stok") & "")
                    dgv.Rows(e.RowIndex).Cells("jumlah").Value = dr("stok")
                End If
            End If
            dgv.Rows(e.RowIndex).Cells(4).Value = dgv.Rows(e.RowIndex).Cells(2).Value * dgv.Rows(e.RowIndex).Cells(3).Value
        End If
        Call hitungharga()
        Call hitungbarang()
    End Sub

    Private Sub dgv_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Delete Then
            dgv.Rows.Remove(dgv.CurrentRow)
            Call hitungharga()
            Call hitungbarang()
        End If
        If e.KeyCode = Keys.Enter Then
            TDibayar.Focus()
        End If
    End Sub
    Private Sub Tdibayar_KeyDown(sender As Object, e As KeyEventArgs) Handles TDibayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TDibayar.Text) < Val(LTotalHarga.Text) Then
                MsgBox("Pembayaran Kurang")
                Exit Sub
            ElseIf Val(TDibayar.Text) = Val(LTotalHarga.Text) Then
                LKembali.Text = 0
                Button1.Focus()
            ElseIf Val(TDibayar.Text) > Val(LTotalHarga.Text) Then
                LKembali.Text = Val(TDibayar.Text) - Val(LTotalHarga.Text)
                Button1.Focus()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or TDibayar.Text = "" Or dgv.RowCount - 1 = 0 Then
            MsgBox("Transaksi belum lengkap")
            Exit Sub
        End If

        Call Koneksi()
        Dim simpanpenjualan As String = "insert into tblpenjualan values('" & LFaktur.Text & "','" & Format(DateValue(LTanggal.Text), "MM/dd/yyyy") & " ','" & ComboBox1.Text & "','" & LTotalHarga.Text & "','" & TDibayar.Text & "','" & LKembali.Text & "','USR01')"
        cmd = New SqlCommand(simpanpenjualan, conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To dgv.RowCount - 2
            Call Koneksi()
            Dim simpandetail As String = "insert into tbldetailjual values ('" & LFaktur.Text & "', '" & dgv.Rows(baris).Cells(0).Value & "', '" & Val(Microsoft.VisualBasic.Str(dgv.Rows(baris).Cells("harga").Value)) & "', '" & Val(Microsoft.VisualBasic.Str(dgv.Rows(baris).Cells("jumlah").Value)) & "', '" & Val(Microsoft.VisualBasic.Str(dgv.Rows(baris).Cells("subTotal").Value)) & "')"
            cmd = New SqlCommand(simpandetail, conn)
            cmd.ExecuteNonQuery()

            Call Koneksi()
            cmd = New SqlCommand("select * from tblbarang where kode_barang = '" & dgv.Rows(baris).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Call Koneksi()
                Dim kurangistok As String = "update tblbarang set stok = '" & dr.Item("stok") - dgv.Rows(baris).Cells(3).Value & "' where kode_barang = '" & dgv.Rows(baris).Cells(0).Value & "'"
                cmd = New SqlCommand(kurangistok, conn)
                cmd.ExecuteNonQuery()
            End If
        Next
        If MessageBox.Show("Apakah yakin data akan dicetak?", "", MessageBoxButtons.YesNo) = vbYes Then
            Cetak.Show()
            Cetak.crv.SelectionFormula = "{tblpenjualan.faktur}" & LFaktur.Text & "'"
            Cetak.crv.ReportSource = "faktur.rpt"
            Cetak.crv.RefreshReport()
        End If
        Call bersihkan()
        Call faktis()
    End Sub
    Sub bersihkan()
        ComboBox1.Text = ""
        LTotalHarga.Text = ""
        TDibayar.Text = ""
        LKembali.Text = ""
        dgv.Rows.Clear()
    End Sub
End Class