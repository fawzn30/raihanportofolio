<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.AutoSize = True
        Me.GroupBox7.Controls.Add(Me.Button17)
        Me.GroupBox7.Controls.Add(Me.Button18)
        Me.GroupBox7.Controls.Add(Me.Button19)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox7.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(234, 114)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'Button17
        '
        Me.Button17.AutoSize = True
        Me.Button17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.Location = New System.Drawing.Point(153, 18)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(78, 93)
        Me.Button17.TabIndex = 2
        Me.Button17.Text = "Customer"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.AutoSize = True
        Me.Button18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Image = CType(resources.GetObject("Button18.Image"), System.Drawing.Image)
        Me.Button18.Location = New System.Drawing.Point(78, 18)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(75, 93)
        Me.Button18.TabIndex = 1
        Me.Button18.Text = "Barang"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.AutoSize = True
        Me.Button19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Image = CType(resources.GetObject("Button19.Image"), System.Drawing.Image)
        Me.Button19.Location = New System.Drawing.Point(3, 18)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(75, 93)
        Me.Button19.TabIndex = 0
        Me.Button19.Text = "User"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button19.UseVisualStyleBackColor = True
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 135)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(800, 315)
        Me.crv.TabIndex = 1
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LaporanMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LaporanMaster"
        Me.Text = "LaporanMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
