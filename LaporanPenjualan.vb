Public Class LaporanPenjualan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        crv.SelectionFormula = "totext({tblpenjualan.tanggal})='" & dtp1.Text & "'"

        crv.ReportSource = "lap penjualan.rpt" 'harian
        crv.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        crv.SelectionFormula = "totext({tblpenjualan.tanggal})='" & dtp2.Text & "'"

        crv.ReportSource = "lap penjualan.rpt" 'periode
        crv.RefreshReport()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        crv.SelectionFormula = "month({tblpenjualan.tanggal}) = (" & Year(dtp4.Text) & ") and year({tblpenjualan.tanggal}) = (" & Year(dtp4.Text) & ")"

        crv.ReportSource = "lap penjualan.rpt" 'bulanan
        crv.RefreshReport()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        crv.SelectionFormula = "year({tblpenjualan.tanggal}) = (" & Year(dtp4.Text) & ") and year({tblpenjualan.tanggal}) = (" & Year(dtp4.Text) & ")"

        crv.ReportSource = "lap penjualan.rpt" 'tahunan
        crv.RefreshReport()
    End Sub
End Class