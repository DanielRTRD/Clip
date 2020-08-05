<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsFull = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowMiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbHistory = New System.Windows.Forms.ListBox()
        Me.cmsLBHistory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearSelectedClipboardHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearALLClipboardHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbHistoryPreview = New System.Windows.Forms.TextBox()
        Me.gbFavorites = New System.Windows.Forms.GroupBox()
        Me.lbFavorites = New System.Windows.Forms.ListBox()
        Me.cmsLBFavorites = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiCopyFavoriteToClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRemoveFromFavorites = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cbTrimText = New System.Windows.Forms.CheckBox()
        Me.cbWhitespace = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cbSilentMode = New System.Windows.Forms.CheckBox()
        Me.cbStartup = New System.Windows.Forms.CheckBox()
        Me.cbTopMost = New System.Windows.Forms.CheckBox()
        Me.cbHistory = New System.Windows.Forms.CheckBox()
        Me.cbMinimized = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbTrayRight = New System.Windows.Forms.ComboBox()
        Me.cbTrayLeft = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbMiniAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.cbMiniStartup = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbHotkeys = New System.Windows.Forms.CheckBox()
        Me.gbHK1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbHK1_Win = New System.Windows.Forms.CheckBox()
        Me.cbHK1_1 = New System.Windows.Forms.ComboBox()
        Me.cbHK1_Shift = New System.Windows.Forms.CheckBox()
        Me.cbHK1_Alt = New System.Windows.Forms.CheckBox()
        Me.cbHK1_Ctrl = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.gbLogsSettings = New System.Windows.Forms.GroupBox()
        Me.btnClearLogs = New System.Windows.Forms.Button()
        Me.btnOpenLogsFolder = New System.Windows.Forms.Button()
        Me.cmsLog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenStartupFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblErrorLogs = New System.Windows.Forms.Label()
        Me.lblSettingFileVersion = New System.Windows.Forms.Label()
        Me.gbClearHistory = New System.Windows.Forms.GroupBox()
        Me.btnClearFavorites = New System.Windows.Forms.Button()
        Me.btnClearHistory = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbChangelog = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnMiniScreenTest = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.tbDebugFavorites = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbDebug = New System.Windows.Forms.TextBox()
        Me.lbDebug = New System.Windows.Forms.ListBox()
        Me.cmsHistory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cbDebug = New System.Windows.Forms.CheckBox()
        Me.btnShowMini = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmsFull.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.cmsLBHistory.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbFavorites.SuspendLayout()
        Me.cmsLBFavorites.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbHK1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.gbLogsSettings.SuspendLayout()
        Me.cmsLog.SuspendLayout()
        Me.gbClearHistory.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Clip.1"
        Me.NotifyIcon1.Visible = True
        '
        'cmsFull
        '
        Me.cmsFull.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripSeparator2, Me.ShowMiniToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.cmsFull.Name = "cmsNotify"
        Me.cmsFull.Size = New System.Drawing.Size(131, 82)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SettingsToolStripMenuItem.Text = "&Show Clip"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(127, 6)
        '
        'ShowMiniToolStripMenuItem
        '
        Me.ShowMiniToolStripMenuItem.Name = "ShowMiniToolStripMenuItem"
        Me.ShowMiniToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ShowMiniToolStripMenuItem.Text = "Show &Mini"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(510, 350)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.gbFavorites)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(502, 324)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "History"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lbHistory)
        Me.GroupBox7.Location = New System.Drawing.Point(274, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(222, 188)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "History:"
        '
        'lbHistory
        '
        Me.lbHistory.ContextMenuStrip = Me.cmsLBHistory
        Me.lbHistory.FormattingEnabled = True
        Me.lbHistory.Location = New System.Drawing.Point(6, 21)
        Me.lbHistory.Name = "lbHistory"
        Me.lbHistory.Size = New System.Drawing.Size(210, 160)
        Me.lbHistory.TabIndex = 3
        '
        'cmsLBHistory
        '
        Me.cmsLBHistory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AddToFavoritesToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearSelectedClipboardHistoryToolStripMenuItem, Me.ClearALLClipboardHistoryToolStripMenuItem})
        Me.cmsLBHistory.Name = "cmsFavorite"
        Me.cmsLBHistory.Size = New System.Drawing.Size(240, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(239, 22)
        Me.ToolStripMenuItem1.Text = "Copy selected to clipboard"
        '
        'AddToFavoritesToolStripMenuItem
        '
        Me.AddToFavoritesToolStripMenuItem.Name = "AddToFavoritesToolStripMenuItem"
        Me.AddToFavoritesToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.AddToFavoritesToolStripMenuItem.Text = "Add selected to favorites"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(236, 6)
        '
        'ClearSelectedClipboardHistoryToolStripMenuItem
        '
        Me.ClearSelectedClipboardHistoryToolStripMenuItem.Name = "ClearSelectedClipboardHistoryToolStripMenuItem"
        Me.ClearSelectedClipboardHistoryToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ClearSelectedClipboardHistoryToolStripMenuItem.Text = "Clear selected clipboard history"
        '
        'ClearALLClipboardHistoryToolStripMenuItem
        '
        Me.ClearALLClipboardHistoryToolStripMenuItem.Name = "ClearALLClipboardHistoryToolStripMenuItem"
        Me.ClearALLClipboardHistoryToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ClearALLClipboardHistoryToolStripMenuItem.Text = "Clear ALL clipboard history"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tbHistoryPreview)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(262, 312)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Preview:"
        '
        'tbHistoryPreview
        '
        Me.tbHistoryPreview.Location = New System.Drawing.Point(6, 21)
        Me.tbHistoryPreview.Multiline = True
        Me.tbHistoryPreview.Name = "tbHistoryPreview"
        Me.tbHistoryPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbHistoryPreview.Size = New System.Drawing.Size(250, 285)
        Me.tbHistoryPreview.TabIndex = 2
        '
        'gbFavorites
        '
        Me.gbFavorites.Controls.Add(Me.lbFavorites)
        Me.gbFavorites.Location = New System.Drawing.Point(274, 200)
        Me.gbFavorites.Name = "gbFavorites"
        Me.gbFavorites.Size = New System.Drawing.Size(222, 118)
        Me.gbFavorites.TabIndex = 5
        Me.gbFavorites.TabStop = False
        Me.gbFavorites.Text = "Favorites:"
        '
        'lbFavorites
        '
        Me.lbFavorites.ContextMenuStrip = Me.cmsLBFavorites
        Me.lbFavorites.FormattingEnabled = True
        Me.lbFavorites.Location = New System.Drawing.Point(6, 17)
        Me.lbFavorites.Name = "lbFavorites"
        Me.lbFavorites.Size = New System.Drawing.Size(210, 95)
        Me.lbFavorites.TabIndex = 4
        '
        'cmsLBFavorites
        '
        Me.cmsLBFavorites.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCopyFavoriteToClipboard, Me.tsmiRemoveFromFavorites})
        Me.cmsLBFavorites.Name = "cmsFavorite"
        Me.cmsLBFavorites.Size = New System.Drawing.Size(241, 48)
        '
        'tsmiCopyFavoriteToClipboard
        '
        Me.tsmiCopyFavoriteToClipboard.Name = "tsmiCopyFavoriteToClipboard"
        Me.tsmiCopyFavoriteToClipboard.Size = New System.Drawing.Size(240, 22)
        Me.tsmiCopyFavoriteToClipboard.Text = "Copy selected to clipboard"
        '
        'tsmiRemoveFromFavorites
        '
        Me.tsmiRemoveFromFavorites.Name = "tsmiRemoveFromFavorites"
        Me.tsmiRemoveFromFavorites.Size = New System.Drawing.Size(240, 22)
        Me.tsmiRemoveFromFavorites.Text = "Remove selected from favorites"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(502, 324)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cbTrimText)
        Me.GroupBox9.Controls.Add(Me.cbWhitespace)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 232)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(222, 69)
        Me.GroupBox9.TabIndex = 30
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Text"
        '
        'cbTrimText
        '
        Me.cbTrimText.AutoSize = True
        Me.cbTrimText.Cursor = System.Windows.Forms.Cursors.Help
        Me.cbTrimText.Location = New System.Drawing.Point(6, 44)
        Me.cbTrimText.Name = "cbTrimText"
        Me.cbTrimText.Size = New System.Drawing.Size(154, 17)
        Me.cbTrimText.TabIndex = 29
        Me.cbTrimText.Text = "Trim text at start and end"
        Me.ToolTip1.SetToolTip(Me.cbTrimText, "Removes whitespace on start and end of copied text.")
        Me.cbTrimText.UseVisualStyleBackColor = True
        '
        'cbWhitespace
        '
        Me.cbWhitespace.AutoSize = True
        Me.cbWhitespace.Cursor = System.Windows.Forms.Cursors.Help
        Me.cbWhitespace.Location = New System.Drawing.Point(6, 21)
        Me.cbWhitespace.Name = "cbWhitespace"
        Me.cbWhitespace.Size = New System.Drawing.Size(214, 17)
        Me.cbWhitespace.TabIndex = 28
        Me.cbWhitespace.Text = "Remove whitespace from copied text"
        Me.ToolTip1.SetToolTip(Me.cbWhitespace, "This removes whitespace from copied text. If you want to keep formatting you shou" &
        "ld not use this setting.")
        Me.cbWhitespace.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cbSilentMode)
        Me.GroupBox8.Controls.Add(Me.cbStartup)
        Me.GroupBox8.Controls.Add(Me.cbTopMost)
        Me.GroupBox8.Controls.Add(Me.cbHistory)
        Me.GroupBox8.Controls.Add(Me.cbMinimized)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 3, 6, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(222, 136)
        Me.GroupBox8.TabIndex = 29
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Main"
        '
        'cbSilentMode
        '
        Me.cbSilentMode.AutoSize = True
        Me.cbSilentMode.Cursor = System.Windows.Forms.Cursors.Help
        Me.cbSilentMode.Location = New System.Drawing.Point(6, 113)
        Me.cbSilentMode.Name = "cbSilentMode"
        Me.cbSilentMode.Size = New System.Drawing.Size(88, 17)
        Me.cbSilentMode.TabIndex = 8
        Me.cbSilentMode.Text = "Silent Mode"
        Me.ToolTip1.SetToolTip(Me.cbSilentMode, "If Silent Mode is enabled you won't see the notifications from the trayicon or an" &
        "y error messages. It will silently continue without user interaction.")
        Me.cbSilentMode.UseVisualStyleBackColor = True
        '
        'cbStartup
        '
        Me.cbStartup.AutoSize = True
        Me.cbStartup.Location = New System.Drawing.Point(6, 21)
        Me.cbStartup.Name = "cbStartup"
        Me.cbStartup.Size = New System.Drawing.Size(123, 17)
        Me.cbStartup.TabIndex = 0
        Me.cbStartup.Text = "Run Clip at startup"
        Me.cbStartup.UseVisualStyleBackColor = True
        '
        'cbTopMost
        '
        Me.cbTopMost.AutoSize = True
        Me.cbTopMost.Location = New System.Drawing.Point(6, 67)
        Me.cbTopMost.Name = "cbTopMost"
        Me.cbTopMost.Size = New System.Drawing.Size(99, 17)
        Me.cbTopMost.TabIndex = 2
        Me.cbTopMost.Text = "Always on top"
        Me.cbTopMost.UseVisualStyleBackColor = True
        '
        'cbHistory
        '
        Me.cbHistory.AutoSize = True
        Me.cbHistory.Cursor = System.Windows.Forms.Cursors.Help
        Me.cbHistory.Location = New System.Drawing.Point(6, 90)
        Me.cbHistory.Name = "cbHistory"
        Me.cbHistory.Size = New System.Drawing.Size(128, 17)
        Me.cbHistory.TabIndex = 3
        Me.cbHistory.Text = "Keep history forever"
        Me.ToolTip1.SetToolTip(Me.cbHistory, "If this is enabled and the file gets too large it will slow down the performance " &
        "of this application.")
        Me.cbHistory.UseVisualStyleBackColor = True
        '
        'cbMinimized
        '
        Me.cbMinimized.AutoSize = True
        Me.cbMinimized.Location = New System.Drawing.Point(6, 44)
        Me.cbMinimized.Name = "cbMinimized"
        Me.cbMinimized.Size = New System.Drawing.Size(128, 17)
        Me.cbMinimized.TabIndex = 7
        Me.cbMinimized.Text = "Start Clip minimized"
        Me.cbMinimized.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.cbTrayRight)
        Me.GroupBox5.Controls.Add(Me.cbTrayLeft)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(240, 146)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(256, 92)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Trayicon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Right click:"
        '
        'cbTrayRight
        '
        Me.cbTrayRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrayRight.FormattingEnabled = True
        Me.cbTrayRight.Items.AddRange(New Object() {"Nothing", "History", "Full Context Menu"})
        Me.cbTrayRight.Location = New System.Drawing.Point(94, 18)
        Me.cbTrayRight.Name = "cbTrayRight"
        Me.cbTrayRight.Size = New System.Drawing.Size(156, 21)
        Me.cbTrayRight.TabIndex = 3
        '
        'cbTrayLeft
        '
        Me.cbTrayLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrayLeft.FormattingEnabled = True
        Me.cbTrayLeft.Items.AddRange(New Object() {"Nothing", "History", "Full Context Menu"})
        Me.cbTrayLeft.Location = New System.Drawing.Point(94, 45)
        Me.cbTrayLeft.Name = "cbTrayLeft"
        Me.cbTrayLeft.Size = New System.Drawing.Size(156, 21)
        Me.cbTrayLeft.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 6.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Double left click opens application."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 48)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Left click:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbMiniAlwaysOnTop)
        Me.GroupBox2.Controls.Add(Me.cbMiniStartup)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 78)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mini"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(2, 60)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 12)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "The application remembers the size and location."
        '
        'cbMiniAlwaysOnTop
        '
        Me.cbMiniAlwaysOnTop.AutoSize = True
        Me.cbMiniAlwaysOnTop.Location = New System.Drawing.Point(6, 42)
        Me.cbMiniAlwaysOnTop.Name = "cbMiniAlwaysOnTop"
        Me.cbMiniAlwaysOnTop.Size = New System.Drawing.Size(99, 17)
        Me.cbMiniAlwaysOnTop.TabIndex = 25
        Me.cbMiniAlwaysOnTop.Text = "Always on top"
        Me.cbMiniAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'cbMiniStartup
        '
        Me.cbMiniStartup.AutoSize = True
        Me.cbMiniStartup.Location = New System.Drawing.Point(6, 19)
        Me.cbMiniStartup.Name = "cbMiniStartup"
        Me.cbMiniStartup.Size = New System.Drawing.Size(138, 17)
        Me.cbMiniStartup.TabIndex = 24
        Me.cbMiniStartup.Text = "Open Mini on startup"
        Me.cbMiniStartup.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbHotkeys)
        Me.GroupBox4.Controls.Add(Me.gbHK1)
        Me.GroupBox4.Location = New System.Drawing.Point(240, 6)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 134)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hotkey"
        '
        'cbHotkeys
        '
        Me.cbHotkeys.AutoSize = True
        Me.cbHotkeys.Location = New System.Drawing.Point(6, 19)
        Me.cbHotkeys.Name = "cbHotkeys"
        Me.cbHotkeys.Size = New System.Drawing.Size(104, 17)
        Me.cbHotkeys.TabIndex = 7
        Me.cbHotkeys.Text = "Enable hotkeys"
        Me.cbHotkeys.UseVisualStyleBackColor = True
        '
        'gbHK1
        '
        Me.gbHK1.Controls.Add(Me.Label1)
        Me.gbHK1.Controls.Add(Me.cbHK1_Win)
        Me.gbHK1.Controls.Add(Me.cbHK1_1)
        Me.gbHK1.Controls.Add(Me.cbHK1_Shift)
        Me.gbHK1.Controls.Add(Me.cbHK1_Alt)
        Me.gbHK1.Controls.Add(Me.cbHK1_Ctrl)
        Me.gbHK1.Enabled = False
        Me.gbHK1.Location = New System.Drawing.Point(6, 42)
        Me.gbHK1.Name = "gbHK1"
        Me.gbHK1.Size = New System.Drawing.Size(244, 86)
        Me.gbHK1.TabIndex = 6
        Me.gbHK1.TabStop = False
        Me.gbHK1.Text = "Show history on mouse pointer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(6, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Two special keys is recommended."
        '
        'cbHK1_Win
        '
        Me.cbHK1_Win.AutoSize = True
        Me.cbHK1_Win.Location = New System.Drawing.Point(97, 45)
        Me.cbHK1_Win.Name = "cbHK1_Win"
        Me.cbHK1_Win.Size = New System.Drawing.Size(75, 17)
        Me.cbHK1_Win.TabIndex = 11
        Me.cbHK1_Win.Text = "Windows"
        Me.cbHK1_Win.UseVisualStyleBackColor = True
        '
        'cbHK1_1
        '
        Me.cbHK1_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHK1_1.FormattingEnabled = True
        Me.cbHK1_1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbHK1_1.Location = New System.Drawing.Point(6, 21)
        Me.cbHK1_1.Name = "cbHK1_1"
        Me.cbHK1_1.Size = New System.Drawing.Size(35, 21)
        Me.cbHK1_1.TabIndex = 10
        '
        'cbHK1_Shift
        '
        Me.cbHK1_Shift.AutoSize = True
        Me.cbHK1_Shift.Location = New System.Drawing.Point(97, 23)
        Me.cbHK1_Shift.Name = "cbHK1_Shift"
        Me.cbHK1_Shift.Size = New System.Drawing.Size(91, 17)
        Me.cbHK1_Shift.TabIndex = 8
        Me.cbHK1_Shift.Text = "Shift (Buggy)"
        Me.cbHK1_Shift.UseVisualStyleBackColor = True
        '
        'cbHK1_Alt
        '
        Me.cbHK1_Alt.AutoSize = True
        Me.cbHK1_Alt.Location = New System.Drawing.Point(47, 45)
        Me.cbHK1_Alt.Name = "cbHK1_Alt"
        Me.cbHK1_Alt.Size = New System.Drawing.Size(40, 17)
        Me.cbHK1_Alt.TabIndex = 2
        Me.cbHK1_Alt.Text = "Alt"
        Me.cbHK1_Alt.UseVisualStyleBackColor = True
        '
        'cbHK1_Ctrl
        '
        Me.cbHK1_Ctrl.AutoSize = True
        Me.cbHK1_Ctrl.Location = New System.Drawing.Point(47, 23)
        Me.cbHK1_Ctrl.Name = "cbHK1_Ctrl"
        Me.cbHK1_Ctrl.Size = New System.Drawing.Size(44, 17)
        Me.cbHK1_Ctrl.TabIndex = 0
        Me.cbHK1_Ctrl.Text = "Ctrl"
        Me.cbHK1_Ctrl.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.gbLogsSettings)
        Me.TabPage5.Controls.Add(Me.gbClearHistory)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(502, 324)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Other"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'gbLogsSettings
        '
        Me.gbLogsSettings.Controls.Add(Me.btnClearLogs)
        Me.gbLogsSettings.Controls.Add(Me.btnOpenLogsFolder)
        Me.gbLogsSettings.Controls.Add(Me.Label9)
        Me.gbLogsSettings.Controls.Add(Me.lblErrorLogs)
        Me.gbLogsSettings.Controls.Add(Me.lblSettingFileVersion)
        Me.gbLogsSettings.Location = New System.Drawing.Point(6, 64)
        Me.gbLogsSettings.Name = "gbLogsSettings"
        Me.gbLogsSettings.Size = New System.Drawing.Size(247, 100)
        Me.gbLogsSettings.TabIndex = 32
        Me.gbLogsSettings.TabStop = False
        Me.gbLogsSettings.Text = "Logs && Settings"
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Location = New System.Drawing.Point(6, 21)
        Me.btnClearLogs.Name = "btnClearLogs"
        Me.btnClearLogs.Size = New System.Drawing.Size(115, 23)
        Me.btnClearLogs.TabIndex = 25
        Me.btnClearLogs.Text = "Clear Log Files"
        Me.btnClearLogs.UseVisualStyleBackColor = True
        '
        'btnOpenLogsFolder
        '
        Me.btnOpenLogsFolder.ContextMenuStrip = Me.cmsLog
        Me.btnOpenLogsFolder.Location = New System.Drawing.Point(127, 21)
        Me.btnOpenLogsFolder.Name = "btnOpenLogsFolder"
        Me.btnOpenLogsFolder.Size = New System.Drawing.Size(115, 23)
        Me.btnOpenLogsFolder.TabIndex = 26
        Me.btnOpenLogsFolder.Text = "Open Logs Folder"
        '
        'cmsLog
        '
        Me.cmsLog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenStartupFolderToolStripMenuItem})
        Me.cmsLog.Name = "cmsLog"
        Me.cmsLog.Size = New System.Drawing.Size(181, 26)
        '
        'OpenStartupFolderToolStripMenuItem
        '
        Me.OpenStartupFolderToolStripMenuItem.Name = "OpenStartupFolderToolStripMenuItem"
        Me.OpenStartupFolderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenStartupFolderToolStripMenuItem.Text = "Open Startup Folder"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(6, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Settings file version:"
        '
        'lblErrorLogs
        '
        Me.lblErrorLogs.AutoSize = True
        Me.lblErrorLogs.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorLogs.Location = New System.Drawing.Point(6, 67)
        Me.lblErrorLogs.Name = "lblErrorLogs"
        Me.lblErrorLogs.Size = New System.Drawing.Size(64, 13)
        Me.lblErrorLogs.TabIndex = 27
        Me.lblErrorLogs.Text = "Log Files: 0"
        '
        'lblSettingFileVersion
        '
        Me.lblSettingFileVersion.AutoSize = True
        Me.lblSettingFileVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSettingFileVersion.Location = New System.Drawing.Point(113, 80)
        Me.lblSettingFileVersion.Name = "lblSettingFileVersion"
        Me.lblSettingFileVersion.Size = New System.Drawing.Size(52, 13)
        Me.lblSettingFileVersion.TabIndex = 29
        Me.lblSettingFileVersion.Text = "0.0.0.000"
        '
        'gbClearHistory
        '
        Me.gbClearHistory.Controls.Add(Me.btnClearFavorites)
        Me.gbClearHistory.Controls.Add(Me.btnClearHistory)
        Me.gbClearHistory.Location = New System.Drawing.Point(6, 6)
        Me.gbClearHistory.Name = "gbClearHistory"
        Me.gbClearHistory.Size = New System.Drawing.Size(247, 52)
        Me.gbClearHistory.TabIndex = 31
        Me.gbClearHistory.TabStop = False
        Me.gbClearHistory.Text = "Clear Your History"
        '
        'btnClearFavorites
        '
        Me.btnClearFavorites.Location = New System.Drawing.Point(127, 21)
        Me.btnClearFavorites.Name = "btnClearFavorites"
        Me.btnClearFavorites.Size = New System.Drawing.Size(115, 23)
        Me.btnClearFavorites.TabIndex = 28
        Me.btnClearFavorites.Text = "Clear Favorites"
        Me.btnClearFavorites.UseVisualStyleBackColor = True
        '
        'btnClearHistory
        '
        Me.btnClearHistory.Location = New System.Drawing.Point(6, 21)
        Me.btnClearHistory.Name = "btnClearHistory"
        Me.btnClearHistory.Size = New System.Drawing.Size(115, 23)
        Me.btnClearHistory.TabIndex = 24
        Me.btnClearHistory.Text = "Clear History"
        Me.btnClearHistory.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.lblVersion)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(502, 324)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "About"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbChangelog)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 242)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Changelog:"
        '
        'tbChangelog
        '
        Me.tbChangelog.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbChangelog.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tbChangelog.Location = New System.Drawing.Point(6, 21)
        Me.tbChangelog.Multiline = True
        Me.tbChangelog.Name = "tbChangelog"
        Me.tbChangelog.ReadOnly = True
        Me.tbChangelog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbChangelog.ShortcutsEnabled = False
        Me.tbChangelog.Size = New System.Drawing.Size(478, 215)
        Me.tbChangelog.TabIndex = 0
        Me.tbChangelog.Text = "Changelog file not found."
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblVersion.Location = New System.Drawing.Point(118, 15)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(88, 13)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "v0.0.0 Build 0000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(78, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Developed by Infihex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clip"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Clip.My.Resources.Resources.clipboard_128
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnMiniScreenTest)
        Me.TabPage3.Controls.Add(Me.Button7)
        Me.TabPage3.Controls.Add(Me.tbDebugFavorites)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.tbDebug)
        Me.TabPage3.Controls.Add(Me.lbDebug)
        Me.TabPage3.Controls.Add(Me.cbDebug)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(502, 324)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Debug"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnMiniScreenTest
        '
        Me.btnMiniScreenTest.Location = New System.Drawing.Point(6, 64)
        Me.btnMiniScreenTest.Name = "btnMiniScreenTest"
        Me.btnMiniScreenTest.Size = New System.Drawing.Size(92, 23)
        Me.btnMiniScreenTest.TabIndex = 28
        Me.btnMiniScreenTest.Text = "miniScreenTest"
        Me.btnMiniScreenTest.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(6, 35)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(92, 23)
        Me.Button7.TabIndex = 26
        Me.Button7.Text = "ContextMenuTest"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'tbDebugFavorites
        '
        Me.tbDebugFavorites.Location = New System.Drawing.Point(6, 95)
        Me.tbDebugFavorites.Multiline = True
        Me.tbDebugFavorites.Name = "tbDebugFavorites"
        Me.tbDebugFavorites.Size = New System.Drawing.Size(224, 97)
        Me.tbDebugFavorites.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(104, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Open Startup Folder"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(388, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "UnRegHotKey()"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(388, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "RegHotKey()"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbDebug
        '
        Me.tbDebug.Location = New System.Drawing.Point(6, 206)
        Me.tbDebug.Multiline = True
        Me.tbDebug.Name = "tbDebug"
        Me.tbDebug.Size = New System.Drawing.Size(224, 112)
        Me.tbDebug.TabIndex = 19
        '
        'lbDebug
        '
        Me.lbDebug.ContextMenuStrip = Me.cmsHistory
        Me.lbDebug.FormattingEnabled = True
        Me.lbDebug.Location = New System.Drawing.Point(259, 64)
        Me.lbDebug.Name = "lbDebug"
        Me.lbDebug.Size = New System.Drawing.Size(237, 108)
        Me.lbDebug.TabIndex = 3
        '
        'cmsHistory
        '
        Me.cmsHistory.Name = "cmsMini"
        Me.cmsHistory.Size = New System.Drawing.Size(61, 4)
        '
        'cbDebug
        '
        Me.cbDebug.AutoSize = True
        Me.cbDebug.Location = New System.Drawing.Point(6, 6)
        Me.cbDebug.Name = "cbDebug"
        Me.cbDebug.Size = New System.Drawing.Size(61, 17)
        Me.cbDebug.TabIndex = 10
        Me.cbDebug.Text = "Debug"
        Me.cbDebug.UseVisualStyleBackColor = True
        '
        'btnShowMini
        '
        Me.btnShowMini.Location = New System.Drawing.Point(12, 368)
        Me.btnShowMini.Name = "btnShowMini"
        Me.btnShowMini.Size = New System.Drawing.Size(129, 23)
        Me.btnShowMini.TabIndex = 8
        Me.btnShowMini.Text = "Show Mini Window"
        Me.btnShowMini.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(447, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tClipboard
        '
        Me.tClipboard.Interval = 400
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(366, 368)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "&Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(285, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(534, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(0, 17)
        Me.tsslStatus.ToolTipText = " "
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 420)
        Me.Controls.Add(Me.btnShowMini)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clip"
        Me.cmsFull.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.cmsLBHistory.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gbFavorites.ResumeLayout(False)
        Me.cmsLBFavorites.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbHK1.ResumeLayout(False)
        Me.gbHK1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.gbLogsSettings.ResumeLayout(False)
        Me.gbLogsSettings.PerformLayout()
        Me.cmsLog.ResumeLayout(False)
        Me.gbClearHistory.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents cmsFull As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cbStartup As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbHistoryPreview As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tClipboard As System.Windows.Forms.Timer
    Friend WithEvents lbDebug As System.Windows.Forms.ListBox
    Friend WithEvents cmsHistory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cbTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents gbHK1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbHK1_Shift As System.Windows.Forms.CheckBox
    Friend WithEvents cbHK1_Alt As System.Windows.Forms.CheckBox
    Friend WithEvents cbHK1_Ctrl As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cbMinimized As System.Windows.Forms.CheckBox
    Friend WithEvents cbDebug As System.Windows.Forms.CheckBox
    Friend WithEvents cbHK1_1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbHotkeys As System.Windows.Forms.CheckBox
    Friend WithEvents cbHK1_Win As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbHistory As System.Windows.Forms.ListBox
    Friend WithEvents tbDebug As System.Windows.Forms.TextBox
    Friend WithEvents lbFavorites As System.Windows.Forms.ListBox
    Friend WithEvents gbFavorites As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbTrayRight As System.Windows.Forms.ComboBox
    Friend WithEvents cbTrayLeft As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmsLog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenStartupFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsLBHistory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToFavoritesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbDebugFavorites As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbChangelog As System.Windows.Forms.TextBox
    Friend WithEvents cmsLBFavorites As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiCopyFavoriteToClipboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRemoveFromFavorites As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbMiniStartup As System.Windows.Forms.CheckBox
    Friend WithEvents cbHistory As System.Windows.Forms.CheckBox
    Friend WithEvents ShowMiniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMiniAlwaysOnTop As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbWhitespace As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowMini As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents btnClearFavorites As System.Windows.Forms.Button
    Friend WithEvents lblErrorLogs As System.Windows.Forms.Label
    Friend WithEvents btnOpenLogsFolder As System.Windows.Forms.Button
    Friend WithEvents btnClearLogs As System.Windows.Forms.Button
    Friend WithEvents btnClearHistory As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbTrimText As System.Windows.Forms.CheckBox
    Friend WithEvents lblSettingFileVersion As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnMiniScreenTest As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cbSilentMode As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearALLClipboardHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearSelectedClipboardHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbClearHistory As GroupBox
    Friend WithEvents gbLogsSettings As GroupBox
End Class
