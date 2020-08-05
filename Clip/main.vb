Imports System.Reflection
Imports System.Security.Principal
Imports System.Runtime.InteropServices
Imports System.Net

Public Class main
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
    Private history As New ToolStripMenuItem("History")
    Private clipSplit As String = "§"
    Private exitClicked As Boolean = False
    Public filesFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Infihex\Clip\"
    Public settingsFilePath As String = filesFolderPath & "Clip.ini"
    Private regcheckFilePath As String = filesFolderPath & "ClipRegCheck.ini"
    Private historyFilePath As String = filesFolderPath & "ClipHistory.txt"
    Private favoritesFilePath As String = filesFolderPath & "ClipFavorites.txt"
    Public logsFilePath As String = filesFolderPath & "\logs\"
    Public clipVersion As String = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." & My.Application.Info.Version.Build.ToString & " Build " & My.Application.Info.Version.Revision.ToString
    Public clipSettingsVersion As String = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." & My.Application.Info.Version.Build.ToString & "." & My.Application.Info.Version.Revision.ToString
    Public clipShortVersion As String = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." & My.Application.Info.Version.Build.ToString
    Public clipMiniVersion As String = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString
    Public ClipBoardGetText As String = Clipboard.GetDataObject().GetData(DataFormats.Text)
    Private identity = WindowsIdentity.GetCurrent()
    Private principal = New WindowsPrincipal(identity)
    Private isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
    Public Const MOD_ALT As Integer = &H1
    Public Const MOD_CONTROL As Integer = &H2
    Public Const MOD_SHIFT As Integer = &H4
    Public Const MOD_WIN As Integer = &H8
    Public Const WM_HOTKEY As Integer = &H312
    <DllImport("User32.dll")> Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function
    <DllImport("User32.dll")> Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "1337"
                    If cbHotkeys.Checked = True Then
                        cmsHistory.Show(Me, Me.PointToClient(MousePosition))
                    End If
            End Select
        End If
        MyBase.WndProc(m)
    End Sub
    Public Shared Function WindowsVersion()
        Dim WindowsVersionText As String = ""
        Dim OSBit As String = ""

        If Environment.Is64BitOperatingSystem = True Then
            OSBit = " 64-Bit"
        Else
            OSBit = " 32-Bit"
        End If

        WindowsVersionText = My.Computer.Info.OSFullName & OSBit & " (" & My.Computer.Info.OSVersion & ")"

        Return WindowsVersionText
    End Function
    Public Sub ApplicationShutdown()
        exitClicked = True
        SaveSettings()
        SaveHistory()
        SaveHistoryFavorites()
        tClipboard.Stop()
        UnRegHotKey()
        Application.Exit()
    End Sub
    Public Sub ApplicationRestart()
        exitClicked = True
        SaveHistory()
        SaveHistoryFavorites()
        tClipboard.Stop()
        UnRegHotKey()
        Application.Restart()
    End Sub
    Public Sub RegHotKey()
        Dim modifiers As Integer
        Dim key As Integer
        'If cbHK1_1.SelectedItem = "Mouse 5" Then
        '    RegisterHotKey(Me.Handle, 1337, modifiers, Keys.XButton1)
        'ElseIf cbHK1_1.SelectedItem = "Mouse 6" Then
        '    RegisterHotKey(Me.Handle, 1337, modifiers, Keys.XButton2)
        'Else
        If cbHK1_Ctrl.Checked Then
            modifiers = modifiers Or MOD_ALT
        End If
        If cbHK1_Alt.Checked Then
            modifiers = modifiers Or MOD_CONTROL
        End If
        If cbHK1_Shift.Checked Then
            modifiers = modifiers Or MOD_SHIFT
        End If
        If cbHK1_Win.Checked Then
            modifiers = modifiers Or MOD_WIN
        End If
        key = Asc(cbHK1_1.SelectedItem.ToString)
        RegisterHotKey(Me.Handle, 1337, modifiers, key)
        'End If

    End Sub
    Public Sub UnRegHotKey()
        UnregisterHotKey(Me.Handle, 1337)
    End Sub
    Public Sub LoadHistory()
        Try
            If IO.File.Exists(historyFilePath) Then
                Dim historyFile As String = IO.File.ReadAllText(historyFilePath)
                'ListBox1.Items.AddRange(historyFile.ToString.Split(clipSplit))
                tbDebug.Text = historyFile.ToString
                For Each tb3split As String In historyFile.ToString.Split(clipSplit)

                    lbDebug.Items.Add(tb3split)
                    lbHistory.Items.Add(tb3split)
                    mini.lbMini.Items.Add(tb3split)

                    'Large
                    Dim subItem As New ToolStripMenuItem(tb3split) 'With {.Width = "100"}
                    history.DropDownItems.Add(subItem)
                    AddHandler subItem.Click, AddressOf subItem_Clicked

                    'Mini
                    Dim subItemMini As New ToolStripMenuItem(tb3split) 'With {.Height = "100"}
                    cmsHistory.Items.Add(subItemMini)
                    AddHandler subItemMini.Click, AddressOf subItem_Clicked

                Next

                For Each item As String In lbDebug.Items
                    item = item.Replace(clipSplit, "")
                Next
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub SaveHistory()
        Try
            If cbHistory.Checked = True Then
                Using streamwriter As New IO.StreamWriter(historyFilePath)
                    For Each str As String In lbDebug.Items
                        streamwriter.WriteLine(str & clipSplit)
                    Next
                End Using
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub LoadHistoryFavorites()
        Try
            If IO.File.Exists(favoritesFilePath) Then
                Dim historyFile As String = IO.File.ReadAllText(favoritesFilePath)
                tbDebugFavorites.Text = historyFile.ToString
                For Each tb3split As String In historyFile.ToString.Split(clipSplit)
                    lbFavorites.Items.Add(tb3split)
                Next
                For Each item As String In lbFavorites.Items
                    item = item.Replace(clipSplit, "")
                Next
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub SaveHistoryFavorites()
        Try
            Using streamwriter As New IO.StreamWriter(favoritesFilePath)
                For Each str As String In lbFavorites.Items
                    streamwriter.WriteLine(str & clipSplit)
                Next
            End Using
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub LoadSettings()
        Try
            Me.lblSettingFileVersion.Text = CStr(Settings.GetSetting("version"))
            Me.cbDebug.Checked = CBool(Settings.GetSetting("debug"))
            Me.cbStartup.Checked = CBool(Settings.GetSetting("startup"))
            Me.cbMinimized.Checked = CBool(Settings.GetSetting("startminimized"))
            Me.cbTopMost.Checked = CBool(Settings.GetSetting("alwaysontop"))
            Me.cbHistory.Checked = CBool(Settings.GetSetting("keephistory"))
            Me.cbTrayRight.SelectedIndex = CInt(Settings.GetSetting("rightclicktrayicon"))
            Me.cbTrayLeft.SelectedIndex = CInt(Settings.GetSetting("leftclicktrayicon"))

            Me.cbHotkeys.Checked = CBool(Settings.GetSetting("hotkeys"))
            Me.cbHK1_1.SelectedItem = CStr(Settings.GetSetting("hk1_key"))
            Me.cbHK1_Ctrl.Checked = CBool(Settings.GetSetting("hk1_ctrl"))
            Me.cbHK1_Alt.Checked = CBool(Settings.GetSetting("hk1_alt"))
            Me.cbHK1_Shift.Checked = CBool(Settings.GetSetting("hk1_shift"))
            Me.cbHK1_Win.Checked = CBool(Settings.GetSetting("hk1_win"))
            Me.cbWhitespace.Checked = CBool(Settings.GetSetting("whitespace"))
            Me.cbTrimText.Checked = CBool(Settings.GetSetting("trimtext"))

            Me.cbMiniStartup.Checked = CBool(Settings.GetSetting("ministartup"))
            Me.cbMiniAlwaysOnTop.Checked = CBool(Settings.GetSetting("minialwaysontop"))
            mini.Size = New Size(CInt(Settings.GetSetting("minisizex")), CInt(Settings.GetSetting("minisizey")))
            'mini.Location = New Point(CInt(Settings.GetSetting("minilocationx")), CInt(Settings.GetSetting("minilocationy")))
            'Read Mini Screen Location
            'Multi Monitor Aware - Restore Postition to last Used
            Dim posX As Integer
            Dim posY As Integer
            ' Read the Position from the INI File
            posX = CInt(Settings.GetSetting("minilocationx"))
            posY = CInt(Settings.GetSetting("minilocationy"))
            Dim pt As New Point(posX, posY)
            If SystemInformation.VirtualScreen.X < posX And SystemInformation.VirtualScreen.Y < posY Then
                pt.X = posX
                pt.Y = posY
            Else
                pt.X = 0
                pt.Y = 0
            End If
            mini.StartPosition = FormStartPosition.Manual
            mini.Location = pt

            Me.cbSilentMode.Checked = CBool(Settings.GetSetting("silentmode"))

            If cbDebug.Checked = True Then
                TabControl1.TabPages.Add(TabPage3)
            ElseIf cbDebug.Checked = False Then
                TabControl1.TabPages.Remove(TabPage3)
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub SaveSettings()
        Try
            Settings.SaveSetting("debug", CStr(cbDebug.Checked.ToInteger))
            Settings.SaveSetting("startup", CStr(cbStartup.Checked.ToInteger))
            Settings.SaveSetting("startminimized", CStr(cbMinimized.Checked.ToInteger))
            Settings.SaveSetting("alwaysontop", CStr(cbTopMost.Checked.ToInteger))
            Settings.SaveSetting("keephistory", CStr(cbHistory.Checked.ToInteger))
            Settings.SaveSetting("rightclicktrayicon", CInt(Me.cbTrayRight.SelectedIndex.ToString))
            Settings.SaveSetting("leftclicktrayicon", CInt(Me.cbTrayLeft.SelectedIndex.ToString))

            Settings.SaveSetting("hotkeys", CStr(cbHotkeys.Checked.ToInteger))
            Settings.SaveSetting("hk1_key", CStr(cbHK1_1.SelectedItem.ToString))
            Settings.SaveSetting("hk1_ctrl", CStr(cbHK1_Ctrl.Checked.ToInteger))
            Settings.SaveSetting("hk1_alt", CStr(cbHK1_Alt.Checked.ToInteger))
            Settings.SaveSetting("hk1_shift", CStr(cbHK1_Shift.Checked.ToInteger))
            Settings.SaveSetting("hk1_win", CStr(cbHK1_Win.Checked.ToInteger))
            Settings.SaveSetting("whitespace", CStr(cbWhitespace.Checked.ToInteger))
            Settings.SaveSetting("trimtext", CStr(cbTrimText.Checked.ToInteger))

            Settings.SaveSetting("ministartup", CStr(cbMiniStartup.Checked.ToInteger))
            Settings.SaveSetting("minialwaysontop", CStr(cbMiniAlwaysOnTop.Checked.ToInteger))
            Settings.SaveSetting("minisizex", CInt(mini.Size.Width.ToString))
            Settings.SaveSetting("minisizey", CInt(mini.Size.Height.ToString))
            Settings.SaveSetting("minilocationx", CInt(mini.Location.X.ToString))
            Settings.SaveSetting("minilocationy", CInt(mini.Location.Y.ToString))

            Settings.SaveSetting("silentmode", CStr(cbSilentMode.Checked.ToInteger))

            If cbStartup.Checked = True Then
                If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue("Clip") Is Nothing Then
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("Clip", """" & Application.ExecutablePath & """", Microsoft.Win32.RegistryValueKind.String)
                Else
                    'Found
                End If
            ElseIf cbStartup.Checked = False Then
                If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue("Clip") Is Nothing Then
                    'Not found
                Else
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("Clip")
                End If
            End If
            tsslStatus.Text = "Settings saved."
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    'Private Sub FindMyString(ByVal searchString As String)
    '    ' Ensure we have a proper string to search for. 
    '    If searchString <> String.Empty Then
    '        ' Find the item in the list and store the index to the item. 
    '        Dim index As Integer = lbDebug.FindString(searchString)
    '        ' Determine if a valid index is returned. Select the item if it is valid. 
    '        If index <> -1 Then
    '            'MsgBox(index.ToString)
    '            lbDebug.SetSelected(index, True)
    '            MsgBox("Item text found!")
    '        End If
    '    End If
    'End Sub
    Private Sub FindTextFromInt(searchInt As Integer)
        Try
            'MsgBox(searchInt)
            Dim count As Integer = lbHistory.Items.Count - 1
            If count < searchInt Then
                lbHistory.SetSelected(0, True)
            Else
                lbHistory.SetSelected(searchInt, True)
            End If
            'MsgBox(lbHistory.SelectedItem.ToString)
            'Clipboard.SetDataObject(data, True, 10, 20)
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ClearAllClipHistory()
        lbHistory.Items.Clear()
        mini.lbMini.Items.Clear()
        cmsHistory.Items.Clear() 'Need to clear the rightclick too
        history.DropDownItems.Clear()
        tbHistoryPreview.Clear()
        Clipboard.Clear()
    End Sub
    Private Sub subItem_Clicked(sender As Object, e As EventArgs)
        Try
            cmsFull.Hide() 'Sometimes the menu items can remain open.
            cmsHistory.Hide() 'Sometimes the menu items can remain open.
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)

            'Dim s As String = item.Text
            's.Substring(0, s.Length)
            'FindMyString(s)
            'MsgBox(cmsHistory.Items.Count)

            FindTextFromInt(item.ShortcutKeyDisplayString)

            If item IsNot Nothing Then
                Clipboard.SetDataObject(lbHistory.SelectedItem.ToString, True, 10, 20)
            End If

            'If item IsNot Nothing Then
            '    Clipboard.SetDataObject(item.Text, True, 10, 20)
            'End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Function ShrinkText(input As String) As String
        Dim output As String
        Dim numOfChar As Integer = 100
        If input.Length > numOfChar Then
            output = input.Substring(0, numOfChar) & "(...)"
        Else
            output = input
        End If
        Return output
    End Function
    Public Sub CheckForExistingInstance()
        Try
            If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
                ErrorHandler.reportError("Multiple Instances Forbidden! Another instance of this process is already running.", "Nothing.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub UpdateSettingsFile(fileVersion As String)
        Try
            ' THIS NEEDS REAL UPDATING

            If fileVersion = "2.1.0.2160" Then
                'write new line with the new setting
            End If

        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub CheckIfOldApplicationFiles()
        Try
            ' Remove old ClipX2 regs
            If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue("ClipX2") IsNot Nothing Then
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("ClipX2")
            End If

            ' Remove old ClipX2 folder
            If IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Intility\ClipX2\") = True Then
                IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Intility\ClipX2\")
            End If

            If IO.File.Exists(settingsFilePath) = True Then

                Dim hash As List(Of String) = New List(Of String)(IO.File.ReadAllLines(settingsFilePath)) ' READ ALL SETTINGS TO LIST
                Dim settingsCheckOK As Integer = 0
                Dim settingsOldFile As Boolean = False
                Dim fileVersion As String = "0.0.0.0000"

                ' READ ALL SETTINGS LINES 
                For Each settingline As String In hash

                    If settingline.Contains("version=") = True Then

                        settingsCheckOK = settingsCheckOK + 1 'Found version line

                        fileVersion = settingline.Split("=").ToString
                        If fileVersion < clipSettingsVersion Then 'If current fileversion is older than current app continue check
                            tsslStatus.Text = "Settings file check: NOT OK"
                            settingsOldFile = True
                        Else
                            tsslStatus.Text = "Settings file check: OK"
                            settingsOldFile = False
                        End If

                    End If

                Next

                If settingsCheckOK = 0 Then ' If no version line is found
                    'This should be reworked.
                    IO.File.Delete(settingsFilePath)
                    MsgBox("There was a problem in the settings file, it has been deleted. Application will now restart. Please change and save your settings again. Sorry for the inconvenience.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly)
                    ApplicationRestart()
                End If

                If settingsOldFile = True Then ' If no version line is found
                    UpdateSettingsFile(fileVersion)
                End If

            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForExistingInstance()
        CheckIfOldApplicationFiles()
        TabControl1.TabPages.Remove(TabPage3)
        LoadSettings()

        'rtechsettings.CreateDefaultSettings() 'TESTING THIS

        tsslStatus.Text = "Ready."
        If System.IO.Directory.Exists(logsFilePath) = False Then
            System.IO.Directory.CreateDirectory(logsFilePath)
        End If
        lblErrorLogs.Text = "Log files: " & My.Computer.FileSystem.GetFiles(logsFilePath).Count

        Try
            btnSave.Enabled = False
            If cbMinimized.Checked = True Then
                Me.WindowState = FormWindowState.Minimized
                Me.Visible = False
                Me.ShowInTaskbar = False
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try

        Try
            If Not IO.File.Exists(historyFilePath) Then
                Using streamwriter As New IO.StreamWriter(historyFilePath)
                    streamwriter.WriteLine("")
                End Using
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try

        If cbHistory.Checked = True Then
            LoadHistory()
        End If

        LoadHistoryFavorites() ' This should be loaded even tho the user has chosen not to keep history

        If cbMiniStartup.Checked = True Then
            mini.Show()
        End If

        Try
            tClipboard.Start()
            cmsFull.Items.Add(history)

            lblVersion.Text = "v" & clipVersion

            tbChangelog.Text = My.Resources.changelog.ToString

            'Dim s As String = cmsMini.Text
            'If cmsMini.Text.Length > 25 Then
            '    cmsMini.Text = cmsMini.Text.Substring(0, 25) & "..."
            'End If
            'cmsMini.ToolTip = s

        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try

        Try
            If cbHotkeys.Checked = True Then
                UnRegHotKey()
                RegHotKey()
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            Me.Focus()
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                If cbSilentMode.Checked = False Then
                    NotifyIcon1.ShowBalloonTip(1, "Clip " & clipMiniVersion, "I am now running minimized.", ToolTipIcon.Info)
                End If
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            ApplicationShutdown()
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tClipboard.Tick

        Try
            If cbHotkeys.Checked = True Then
                If GetAsyncKeyState(Keys.LButton) Or GetAsyncKeyState(Keys.RButton) Then
                    cmsHistory.Hide()
                End If
            End If
        Catch ex As Exception
            tClipboard.Stop()
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try

        Try
            If GetAsyncKeyState(Keys.LButton) Or GetAsyncKeyState(Keys.RButton) Then
                cmsFull.Hide()
            End If
            Dim ClipBoardText As String = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)

            If (ClipBoardText) Then

                Dim GetClipBoard As String

                If (ClipBoardText) Then
                    GetClipBoard = Clipboard.GetDataObject().GetData(DataFormats.Text).ToString()
                Else
                    GetClipBoard = ""
                End If

                'Remove whitespace
                If cbWhitespace.Checked = True Then
                    Dim mystring As String = GetClipBoard
                    While mystring.Contains("  ") '2 spaces.
                        mystring = mystring.Replace("  ", " ") 'Replace with 1 space.
                    End While
                    GetClipBoard = mystring
                End If

                'Trim text
                If cbTrimText.Checked = True Then
                    Dim charsToTrim() As Char = {" "c}
                    Dim banner As String = GetClipBoard
                    Dim result As String = banner.Trim(charsToTrim)
                    GetClipBoard = result
                End If

                tbHistoryPreview.Text = GetClipBoard

                Dim index As Integer = lbDebug.FindString(GetClipBoard)
                ' Determine if a valid index is returned. Select the item if it is valid. 
                If index <> -1 Then
                    lbDebug.SetSelected(index, True)
                Else

                    lbDebug.Items.Add(GetClipBoard)
                    lbHistory.Items.Add(GetClipBoard)
                    mini.lbMini.Items.Add(GetClipBoard)
                    mini.lbMini.TopIndex = mini.lbMini.Items.Count - 1 'Auto scroll

                    'CBItem = First(CBItem, 100)
                    Dim subItem As New ToolStripMenuItem(ShrinkText(GetClipBoard)) 'With {.Width = "100"}
                    history.DropDownItems.Add(subItem)
                    AddHandler subItem.Click, AddressOf subItem_Clicked
                    ' Distinguish the merged items by setting the shortcut display string. 
                    Dim tsmi As ToolStripMenuItem
                    Dim int As Integer = 0
                    For Each tsmi In history.DropDownItems
                        tsmi.ShortcutKeyDisplayString = int
                        int = int + 1
                    Next tsmi

                    'Mini
                    Dim subItemMini As New ToolStripMenuItem(ShrinkText(GetClipBoard)) 'With {.Width = "100"}
                    cmsHistory.Items.Add(subItemMini)
                    AddHandler subItemMini.Click, AddressOf subItem_Clicked
                    ' Distinguish the merged items by setting the shortcut display string. 
                    For Each tsmi In cmsHistory.Items
                        tsmi.ShortcutKeyDisplayString = int
                        int = int + 1
                    Next tsmi

                End If
            End If

        Catch ex As Exception
            ' THIS NEEDS TO BE FIXED! ===========
            'tClipboard.Stop()
            'ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If cbHotkeys.Checked = False Then
                UnRegHotKey()
            ElseIf cbHotkeys.Checked = True Then
                UnRegHotKey()
                RegHotKey()
            End If
            SaveSettings()
            btnSave.Enabled = False
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            ApplicationShutdown()
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If e.CloseReason = CloseReason.WindowsShutDown Then
                ApplicationShutdown()
            End If
            If exitClicked = False Then
                e.Cancel = True
                Me.WindowState = FormWindowState.Minimized
                Me.Visible = False
                If cbSilentMode.Checked = False Then
                    NotifyIcon1.ShowBalloonTip(1, "Clip " & clipMiniVersion, "I am now running minimized.", ToolTipIcon.Info)
                End If
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbTopMost.CheckedChanged
        Try
            btnSave.Enabled = True
            If cbTopMost.Checked = True Then
                Me.TopMost = True
            ElseIf cbTopMost.Checked = False Then
                Me.TopMost = False
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Try
            If Me.WindowState = FormWindowState.Normal Then
                Me.Visible = False
                If cbSilentMode.Checked = False Then
                    NotifyIcon1.ShowBalloonTip(1, "Clip " & clipMiniVersion, "I am now running minimized.", ToolTipIcon.Info)
                End If
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            cmsHistory.Items.Clear()
            history.DropDownItems.Clear()
            lbDebug.Items.Clear()
            lbHistory.Items.Clear()
            tbHistoryPreview.Text = ""
            mini.lbMini.Items.Clear()
            Using streamwriter As New IO.StreamWriter(historyFilePath)
                streamwriter.WriteLine("")
            End Using
            tsslStatus.Text = "History file has been cleared!"
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cbHotkeys_CheckedChanged(sender As Object, e As EventArgs) Handles cbHotkeys.CheckedChanged
        btnSave.Enabled = True
        If cbHotkeys.Checked = True Then
            gbHK1.Enabled = True
        ElseIf cbHotkeys.Checked = False Then
            gbHK1.Enabled = False
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDown(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDown
        Try

            'LEFT
            If e.Button = Windows.Forms.MouseButtons.Left Then
                If cbTrayLeft.SelectedIndex = 0 Then
                    cmsFull.Hide()
                    cmsHistory.Hide()
                ElseIf cbTrayLeft.SelectedIndex = 1 Then
                    'cmsHistory.Show(Me, Me.PointToClient(MousePosition))
                    NotifyIcon1.ContextMenuStrip = cmsHistory
                    NotifyIcon1.ContextMenuStrip.Show(Me, Me.PointToClient(MousePosition))
                ElseIf cbTrayLeft.SelectedIndex = 2 Then
                    'cmsFull.Show(Me, Me.PointToClient(MousePosition))
                    NotifyIcon1.ContextMenuStrip = cmsFull
                    NotifyIcon1.ContextMenuStrip.Show(Me, Me.PointToClient(MousePosition))
                End If
            End If

            'RIGHT
            If e.Button = Windows.Forms.MouseButtons.Right Then
                If cbTrayRight.SelectedIndex = 0 Then
                    cmsFull.Hide()
                    cmsHistory.Hide()
                ElseIf cbTrayRight.SelectedIndex = 1 Then
                    'cmsHistory.Show(Me, Me.PointToClient(MousePosition))
                    NotifyIcon1.ContextMenuStrip = cmsHistory
                ElseIf cbTrayRight.SelectedIndex = 2 Then
                    'cmsFull.Show(Me, Me.PointToClient(MousePosition))
                    NotifyIcon1.ContextMenuStrip = cmsFull
                End If
            End If


        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            Process.Start(Application.StartupPath)
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Try
            Process.Start(logsFilePath)
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Try
            Throw New Exception("Oh snap! No error.")
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles lbHistory.DoubleClick
        Try
            If lbHistory.SelectedItem Then
                Clipboard.SetDataObject(lbHistory.SelectedItem.ToString, True, 10, 20)
                tsslStatus.Text = "Text copied to the clipboard."
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cbDebug_CheckedChanged(sender As Object, e As EventArgs) Handles cbDebug.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub cbHK1_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHK1_1.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub
    Private Sub cbHK1_2_CheckedChanged(sender As Object, e As EventArgs) Handles cbHK1_Ctrl.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub cbHK1_3_CheckedChanged(sender As Object, e As EventArgs) Handles cbHK1_Alt.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub cbHK1_4_CheckedChanged(sender As Object, e As EventArgs) Handles cbHK1_Shift.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbHK1_Win.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub cbStartup_CheckedChanged(sender As Object, e As EventArgs) Handles cbStartup.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub cbHistory_CheckedChanged(sender As Object, e As EventArgs) Handles cbHistory.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub cbMinimized_CheckedChanged(sender As Object, e As EventArgs) Handles cbMinimized.CheckedChanged
        btnSave.Enabled = True
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RegHotKey()
        MsgBox("Registered Hotkey!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, Application.ProductName)
    End Sub
    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        UnRegHotKey()
        MsgBox("Unregistered Hotkey!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, Application.ProductName)
    End Sub
    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub OpenStartupFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenStartupFolderToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath)
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cmsFavorite_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsLBHistory.Opening
        If lbHistory.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Clipboard.SetDataObject(lbHistory.SelectedItem.ToString, True, 10, 20)
            tsslStatus.Text = "Text copied to the clipboard."
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub AddToFavoritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToFavoritesToolStripMenuItem.Click
        Try
            lbFavorites.Items.Add(lbHistory.SelectedItem.ToString)
            SaveHistoryFavorites()
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnClearFavorites_Click(sender As Object, e As EventArgs)
        Try
            lbFavorites.Items.Clear()
            Using streamwriter As New IO.StreamWriter(favoritesFilePath)
                streamwriter.WriteLine("")
            End Using
            tsslStatus.Text = "Favorties file has been cleared!"
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cmsLBFavorites_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsLBFavorites.Opening
        If lbFavorites.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub
    Public Shared Sub RemoveAtLine(filePath As String, TextToRemove As String)
        Try
            If (String.IsNullOrEmpty(filePath)) Then
                Return
            End If

            Dim lines As New List(Of String)(IO.File.ReadAllLines(filePath))
            If lines.Contains(TextToRemove) Then
                lines.Remove(TextToRemove)
            End If

            IO.File.WriteAllLines(filePath, lines.ToArray())
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ShowMiniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMiniToolStripMenuItem.Click
        mini.Show()
    End Sub

    Private Sub cbMiniStartup_CheckedChanged(sender As Object, e As EventArgs) Handles cbMiniStartup.CheckedChanged
        btnSave.Enabled = True
    End Sub

    Private Sub cbMiniAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles cbMiniAlwaysOnTop.CheckedChanged
        Try
            btnSave.Enabled = True
            If cbMiniAlwaysOnTop.Checked = True Then
                mini.TopMost = True
            ElseIf cbMiniAlwaysOnTop.Checked = False Then
                mini.TopMost = False
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbWhitespace_CheckedChanged(sender As Object, e As EventArgs) Handles cbWhitespace.CheckedChanged
        btnSave.Enabled = True
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(Application.StartupPath)
    End Sub

    Private Sub btnShowMini_Click(sender As Object, e As EventArgs) Handles btnShowMini.Click
        mini.Show()
        mini.Focus()
    End Sub
    Private Sub tsmiCopyFavoriteToClipboard_Click(sender As Object, e As EventArgs) Handles tsmiCopyFavoriteToClipboard.Click
        Try
            Clipboard.SetDataObject(lbFavorites.SelectedItem.ToString, True, 10, 20)
            tsslStatus.Text = "Text copied to the clipboard."
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tsmiRemoveFromFavorites_Click(sender As Object, e As EventArgs) Handles tsmiRemoveFromFavorites.Click
        Try
            RemoveAtLine(favoritesFilePath, lbFavorites.SelectedItem.ToString)
            lbFavorites.Items.RemoveAt(lbFavorites.SelectedIndex)
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbTrayRight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTrayRight.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub

    Private Sub cbTrayLeft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTrayLeft.SelectedIndexChanged
        btnSave.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnMiniScreenTest.Click
        Dim miniScreenLength As Integer = Screen.AllScreens.Length - 1
        For i As Integer = 0 To miniScreenLength
            If Screen.AllScreens(i).DeviceName.ToString = Screen.FromControl(mini).DeviceName.ToString Then
                MsgBox(i)
            End If
        Next
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles btnOpenLogsFolder.Click
        Process.Start(logsFilePath)
    End Sub

    Private Sub cbSilentMode_CheckedChanged(sender As Object, e As EventArgs) Handles cbSilentMode.CheckedChanged
        btnSave.Enabled = True
    End Sub

    Private Sub btnClearLogs_Click_1(sender As Object, e As EventArgs) Handles btnClearLogs.Click
        Try
            Dim file As String
            For Each file In System.IO.Directory.GetFiles(logsFilePath)
                System.IO.File.Delete(file)
            Next file
            lblErrorLogs.Text = "Log files: 0"
            tsslStatus.Text = "Log files has been deleted!"
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbOptOutErrorEmail_CheckedChanged(sender As Object, e As EventArgs)
        btnSave.Enabled = True
    End Sub

    Private Sub ClearALLClipboardHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearALLClipboardHistoryToolStripMenuItem.Click
        Try
            ClearAllClipHistory()
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnClearHistory_Click(sender As Object, e As EventArgs) Handles btnClearHistory.Click
        Try
            ClearAllClipHistory()
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ClearSelectedClipboardHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSelectedClipboardHistoryToolStripMenuItem.Click
        Try
            Dim deleteID As Integer = lbHistory.SelectedIndex
            MsgBox(deleteID)
            mini.lbMini.Items.RemoveAt(deleteID)
            cmsHistory.Items.RemoveAt(deleteID)
            'Dim i As Integer
            'For i = 0 To lbHistory.Items.Count - 1
            '    cmsHistory.Items.RemoveAt(i) 'Needs to remove from the right-click too, but does not work RN
            'Next
            lbHistory.Items.RemoveAt(deleteID)
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("https://infihex.com/")
    End Sub
End Class