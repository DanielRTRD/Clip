Public Class Settings
    Public Shared Sub CreateSettingsFile()
        Try
            If System.IO.Directory.Exists(main.filesFolderPath) = False Then
                System.IO.Directory.CreateDirectory(main.filesFolderPath)
            End If
            Dim default_settings As String = "version=" & main.clipSettingsVersion & vbNewLine & "debug=0" & vbNewLine & "startup=0" & vbNewLine _
                                            & "startminimized=0" & vbNewLine & "alwaysontop=0" & vbNewLine & "keephistory=0" & vbNewLine _
                                            & "rightclicktrayicon=2" & vbNewLine & "leftclicktrayicon=0" & vbNewLine & "hotkeys=0" & vbNewLine _
                                            & "hk1_key=X" & vbNewLine & "hk1_ctrl=1" & vbNewLine & "hk1_alt=1" & vbNewLine _
                                            & "hk1_shift=0" & vbNewLine & "hk1_win=0" & vbNewLine & "whitespace=0" & vbNewLine & "trimtext=0" _
                                            & vbNewLine & "ministartup=0" & vbNewLine & "minialwaysontop=0" & vbNewLine & "minisizex=0" _
                                            & vbNewLine & "minisizey=0" & vbNewLine & "minilocationx=0" & vbNewLine & "minilocationy=0" _
                                            & vbNewLine & "silentmode=0" & vbNewLine & "optouterroremail=0"
            If System.IO.File.Exists(main.settingsFilePath) = False Then
                System.IO.File.WriteAllText(main.settingsFilePath, default_settings)
            End If
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Shared Function GetSetting(ByVal Name As String) As String
        CreateSettingsFile()

        Dim setting_lines() As String = System.IO.File.ReadAllLines(main.settingsFilePath)

        For Each line As String In setting_lines
            Dim setting_name As String = line.GetSplit(0, "=")
            Dim setting_value As String = line.GetSplit(1, "=")

            If setting_name = Name Then
                Return setting_value
            End If
        Next

        Return ""
    End Function
    Public Shared Sub SaveSetting(ByVal Name As String, ByVal Value As String)
        Try
            CreateSettingsFile()

            Dim setting_lines() As String = System.IO.File.ReadAllLines(main.settingsFilePath)
            Dim save_lines As New List(Of String)

            For Each line As String In setting_lines
                Dim setting_name As String = line.GetSplit(0, "=")
                Dim setting_value As String = line.GetSplit(1, "=")

                If setting_name = Name Then
                    setting_value = Value
                End If

                save_lines.Add(setting_name & "=" & setting_value)
            Next

            System.IO.File.WriteAllLines(main.settingsFilePath, save_lines.ToArray())
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
End Class