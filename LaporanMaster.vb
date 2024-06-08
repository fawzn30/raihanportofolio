Public Class LaporanMaster
    Private Sub LaporanMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.WindowState=FormWindowState.Maximized
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        crv.ReportSource = "customer.rpt"
        crv.RefreshReport()
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        crv.ReportSource = "barang.rpt"
        crv.RefreshReport()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        crv.ReportSource = "user.rpt"
        crv.RefreshReport()
    End Sub
End Class