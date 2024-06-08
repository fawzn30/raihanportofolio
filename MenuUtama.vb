Public Class MenuUtama
    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        User.Show()

    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Barang.Show()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Customer.Show()

    End Sub

    Private Sub TutupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutupToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Barang.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Customer.Show()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        End

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        End
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        User.Show()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Barang.Show()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Customer.Show()

    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowsState = FormWindowsState.Maximized
        On Error Resume Next
        PictureBox1.Load("img2.jpg.jpeg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        On Error Resume Next
        OpenFileDialog1.ShowDialog()
        PictureBox1.Load(OpenFileDialog1.FileName)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Penjualan.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Close()
        Login.Show()
        Login.tnama.Clear()
        Login.tpassword.Clear()
        Login.tnama.Focus()
    End Sub
End Class