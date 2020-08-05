<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mini
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mini))
        Me.lbMini = New System.Windows.Forms.ListBox()
        Me.tMiniSave = New System.Windows.Forms.Timer(Me.components)
        Me.cmsMini = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearAllHistoryInMiniWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMini.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbMini
        '
        Me.lbMini.ContextMenuStrip = Me.cmsMini
        Me.lbMini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbMini.FormattingEnabled = True
        Me.lbMini.Location = New System.Drawing.Point(0, 0)
        Me.lbMini.Name = "lbMini"
        Me.lbMini.Size = New System.Drawing.Size(284, 261)
        Me.lbMini.TabIndex = 0
        '
        'tMiniSave
        '
        Me.tMiniSave.Interval = 1000
        '
        'cmsMini
        '
        Me.cmsMini.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearAllHistoryInMiniWindowToolStripMenuItem})
        Me.cmsMini.Name = "cmsMini"
        Me.cmsMini.Size = New System.Drawing.Size(241, 26)
        '
        'ClearAllHistoryInMiniWindowToolStripMenuItem
        '
        Me.ClearAllHistoryInMiniWindowToolStripMenuItem.Name = "ClearAllHistoryInMiniWindowToolStripMenuItem"
        Me.ClearAllHistoryInMiniWindowToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ClearAllHistoryInMiniWindowToolStripMenuItem.Text = "Clear all history in Mini window"
        '
        'mini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lbMini)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "mini"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clip.1 - Mini"
        Me.cmsMini.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbMini As System.Windows.Forms.ListBox
    Friend WithEvents tMiniSave As System.Windows.Forms.Timer
    Friend WithEvents cmsMini As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearAllHistoryInMiniWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
