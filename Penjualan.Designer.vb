<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Penjualan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lnamacustomer = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LTanggal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LFaktur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TDibayar = New System.Windows.Forms.TextBox()
        Me.LKembali = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LTotalHarga = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lnamacustomer)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LTanggal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LFaktur)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Lnamacustomer
        '
        Me.Lnamacustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lnamacustomer.Location = New System.Drawing.Point(410, 38)
        Me.Lnamacustomer.Name = "Lnamacustomer"
        Me.Lnamacustomer.Size = New System.Drawing.Size(266, 23)
        Me.Lnamacustomer.TabIndex = 7
        Me.Lnamacustomer.Text = "Lnamacustomer"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(274, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nama Customer"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(410, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(274, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Customer"
        '
        'LTanggal
        '
        Me.LTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LTanggal.Location = New System.Drawing.Point(138, 35)
        Me.LTanggal.Name = "LTanggal"
        Me.LTanggal.Size = New System.Drawing.Size(119, 23)
        Me.LTanggal.TabIndex = 3
        Me.LTanggal.Text = "LTanggal"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(0, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'LFaktur
        '
        Me.LFaktur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LFaktur.Location = New System.Drawing.Point(138, 12)
        Me.LFaktur.Name = "LFaktur"
        Me.LFaktur.Size = New System.Drawing.Size(119, 23)
        Me.LFaktur.TabIndex = 1
        Me.LFaktur.Text = "LFaktur"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(0, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Faktur"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 424)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(755, 152)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TDibayar)
        Me.GroupBox4.Controls.Add(Me.LKembali)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.LTotalHarga)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(246, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(517, 131)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Transaksi"
        '
        'TDibayar
        '
        Me.TDibayar.Location = New System.Drawing.Point(303, 57)
        Me.TDibayar.Name = "TDibayar"
        Me.TDibayar.Size = New System.Drawing.Size(127, 22)
        Me.TDibayar.TabIndex = 7
        Me.TDibayar.Text = "TDibayar"
        '
        'LKembali
        '
        Me.LKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LKembali.Location = New System.Drawing.Point(303, 82)
        Me.LKembali.Name = "LKembali"
        Me.LKembali.Size = New System.Drawing.Size(127, 23)
        Me.LKembali.TabIndex = 6
        Me.LKembali.Text = "LKembali"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(164, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 23)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Kembali"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(164, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Dibayar"
        '
        'LTotalHarga
        '
        Me.LTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LTotalHarga.Location = New System.Drawing.Point(303, 31)
        Me.LTotalHarga.Name = "LTotalHarga"
        Me.LTotalHarga.Size = New System.Drawing.Size(127, 23)
        Me.LTotalHarga.TabIndex = 3
        Me.LTotalHarga.Text = "LTotalHarga"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(164, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total Harga"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(243, 131)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proses"
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(153, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 110)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Tutup"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(78, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 110)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Batal"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(3, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 110)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Nama, Me.Harga, Me.Jumlah, Me.SubTotal})
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 96)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(755, 328)
        Me.dgv.TabIndex = 2
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode Barang"
        Me.Kode.MinimumWidth = 6
        Me.Kode.Name = "Kode"
        Me.Kode.Width = 125
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Barang"
        Me.Nama.MinimumWidth = 6
        Me.Nama.Name = "Nama"
        Me.Nama.Width = 200
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.MinimumWidth = 6
        Me.Harga.Name = "Harga"
        Me.Harga.Width = 125
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.MinimumWidth = 6
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 125
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.MinimumWidth = 6
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Width = 125
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 576)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LTanggal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LFaktur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TDibayar As TextBox
    Friend WithEvents LKembali As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LTotalHarga As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Lnamacustomer As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
End Class
