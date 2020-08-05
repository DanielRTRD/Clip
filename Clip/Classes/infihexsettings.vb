Imports Microsoft.Win32
Public Class infihexsettings
    Public Shared Sub CreateSetting(keyname As String, keyvalue As String, keytype As RegistryValueKind)
        Try
            If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\" & Application.CompanyName & "\" & Application.ProductName, True).GetValue(keyname) Is Nothing Then ' Not Found
                My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\" & Application.CompanyName & "\" & Application.ProductName, True).SetValue(keyname, keyvalue, keytype)
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub CreateDefaultSettings()
        Try
            If My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\" & Application.CompanyName & "\" & Application.ProductName, True) Is Nothing Then ' Not Found
                My.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\" & Application.CompanyName & "\" & Application.ProductName, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryOptions.None)
            End If
            'CreateSetting("version", main.clipx2settingsversion, RegistryValueKind.DWord)
            'Dim defaultSettings(2, 2) As String
            'defaultSettings(0, 0) = "version"
            'defaultSettings(0, 1) = main.clipx2settingsversion
            'defaultSettings(0, 2) = 1 'string
            'defaultSettings(1, 0) = "debug"
            'defaultSettings(1, 1) = 0
            'defaultSettings(1, 2) = 4 'dword
            'defaultSettings(2, 0) = "startup"
            'defaultSettings(2, 1) = 0
            'defaultSettings(2, 2) = 4 'dword
            'Array("startminimized", 0, 4),
            '                            ("alwaysontop", 0, 4), Array("keephistory", 0, 4),
            '                            ("rightclicktrayicon", 2, 4), Array("leftclicktrayicon", 0, 4),
            '                            ("hotkeys", 0, 4), Array("hk1_key", "X", 1),
            '                            ("hk1_ctrl", 1, 4), Array("hk1_alt", 1, 4),
            '                            ("hk1_shift", 0, 4), Array("hk1_win", 0, 4),
            '                            ("whitespace", 0, 4), Array("trimtext", 0, 4),
            '                            ("ministartup", 0, 4), Array("minialwaysontop", 0, 4),
            '                            ("minisizex", 0, 4), Array("minisizey", 0, 4),
            '                            ("minilocationx", 0, 4), Array("minilocationy", 0, 4),
            '                            ("silentmode", 0, 4), Array("optouterroremail", 0, 4) '4 = dword / 1 = string
            'For Each setting In defaultSettings
            '    'CreateSetting(setting(0), setting(1), setting(2))
            '    MsgBox(setting[0] & vbNewLine & setting(1) & vbNewLine & setting(2))
            'Next

            'For i = 0 To defaultSettings.Length
            '    'MsgBox(defaultSettings(i, 0) & vbNewLine & defaultSettings(i, 1) & vbNewLine & defaultSettings(i, 2))
            '    CreateSetting(defaultSettings(i, 0).ToString, defaultSettings(i, 1).ToString, Int(defaultSettings(i, 2)))
            'Next
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub LoadSettings()
        Try
            Throw New NotImplementedException
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Sub SaveSettings()
        Try
            Throw New NotImplementedException
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
