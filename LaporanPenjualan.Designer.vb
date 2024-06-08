<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtp4 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp3 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(925, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.dtp4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(395, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(196, 101)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bulanan/Tahunan"
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.Location = New System.Drawing.Point(3, 52)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Bulanan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.Location = New System.Drawing.Point(3, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Tahunan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtp4
        '
        Me.dtp4.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtp4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp4.Location = New System.Drawing.Point(3, 18)
        Me.dtp4.Name = "dtp4"
        Me.dtp4.Size = New System.Drawing.Size(190, 22)
        Me.dtp4.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtp3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.dtp2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(199, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 101)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Periode"
        '
        'dtp3
        '
        Me.dtp3.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtp3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp3.Location = New System.Drawing.Point(3, 40)
        Me.dtp3.Name = "dtp3"
        Me.dtp3.Size = New System.Drawing.Size(190, 22)
        Me.dtp3.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.Location = New System.Drawing.Point(3, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(3, 18)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(190, 22)
        Me.dtp2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.dtp1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 101)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Harian"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(3, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(3, 18)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(190, 22)
        Me.dtp1.TabIndex = 0
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 122)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(925, 451)
        Me.crv.TabIndex = 1
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(591, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 101)
        Me.ListBox1.TabIndex = 3
        '
        'LaporanPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 573)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LaporanPenjualan"
        Me.Text = "LaporanPenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtp3 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents dtp4 As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
