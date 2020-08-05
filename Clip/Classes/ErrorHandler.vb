Imports System.DirectoryServices.AccountManagement

Public Class ErrorHandler
    Public Shared Sub reportError(errorMessage As String, errorDetails As String, errorType As Integer)
        Try

            Dim statusText As String = "I ran into a wall, please wait."
            Dim errorTypeText As String = ""
            Dim tooltipicontype As Integer = 0
            Dim usermessage As String = ""
            Dim daErrorMsg As String = ""

            If errorType = MsgBoxStyle.Critical Then
                errorTypeText = "Error"
                main.btnExit.Enabled = False
                main.btnHide.Enabled = False
                tooltipicontype = ToolTipIcon.Error
            ElseIf errorType = MsgBoxStyle.Exclamation Then
                errorTypeText = "Warning"
                tooltipicontype = ToolTipIcon.Warning
            End If

            main.tsslStatus.Text = statusText
            If main.cbSilentMode.Checked = False Then
                main.NotifyIcon1.ShowBalloonTip(1, "Clip " & main.clipMiniVersion, statusText, tooltipicontype)
            End If

            If errorType = MsgBoxStyle.Critical Then
                usermessage = "The application ran into a wall, please wait while we gather the bricks. The application might need to restart." & _
                vbNewLine & vbNewLine & "Error: " & errorMessage & vbNewLine & vbNewLine & "Do you want to restart the application?"
            ElseIf errorType = MsgBoxStyle.Exclamation Then
                usermessage = "Warning: " & errorMessage
            End If

            daErrorMsg = "Date and Time: " & DateTime.Now.ToString("dd. MMMM yyyy HH:mm:ss") & vbNewLine
            daErrorMsg = daErrorMsg & "Debug Mode: " & main.cbDebug.Checked.ToString & vbNewLine
            daErrorMsg = daErrorMsg & "Application Version: " & main.clipVersion & vbNewLine & vbNewLine
            daErrorMsg = daErrorMsg & "Domain: " & Environment.UserDomainName & vbNewLine
            daErrorMsg = daErrorMsg & "Username: " & Environment.UserName & vbNewLine
            daErrorMsg = daErrorMsg & "Displayname: " & UserPrincipal.Current.DisplayName & vbNewLine
            daErrorMsg = daErrorMsg & "Computername: " & Environment.MachineName & vbNewLine
            daErrorMsg = daErrorMsg & "Windows: " & main.WindowsVersion() & vbNewLine & vbNewLine
            Try
                'This might cause a log error
                daErrorMsg = daErrorMsg & "User Last Copied Text: " & vbNewLine & main.ClipBoardGetText.ToString() & vbNewLine & vbNewLine
            Catch ex As Exception
                daErrorMsg = daErrorMsg & "User Last Copied Text: " & vbNewLine & "//COULD NOT GET COPIED TEXT//" & vbNewLine & vbNewLine
            End Try
            daErrorMsg = daErrorMsg & "User " & errorTypeText & " Message: " & vbNewLine & usermessage & vbNewLine & vbNewLine
            daErrorMsg = daErrorMsg & "Application " & errorTypeText & " Message: " & vbNewLine & errorMessage & vbNewLine & vbNewLine
            daErrorMsg = daErrorMsg & "Detailed Application " & errorTypeText & " Message: " & vbNewLine & errorDetails

            'LOG FILE
            If System.IO.Directory.Exists(main.logsFilePath) = False Then
                System.IO.Directory.CreateDirectory(main.logsFilePath)
            End If
            IO.File.WriteAllText(main.logsFilePath & DateTime.Now.ToString("dd-MM-yyyy-HH_mm_ss") & ".log", daErrorMsg)

            main.tsslStatus.Text = "I am gathering bricks, please wait."
            main.lblErrorLogs.Text = "Log files: " & My.Computer.FileSystem.GetFiles(main.logsFilePath).Count

            If errorType = MsgBoxStyle.Critical Then
                If main.cbSilentMode.Checked = False Then
                    showMessageBox(errorType, usermessage)
                End If
            ElseIf errorType = MsgBoxStyle.Exclamation Then
                If main.cbSilentMode.Checked = False Then
                    showMessageBox(errorType, usermessage)
                End If
            End If

        Catch ex As Exception
            errorHandlerProblem("LOG", ex.Message(), ex.StackTrace())
        End Try
    End Sub
    Public Shared Sub showMessageBox(errorType As Long, usermessage As String)
        Try
            If main.cbSilentMode.Checked = False Then 'SILENT MODE
                If errorType = MsgBoxStyle.Critical Then
                    Dim msg = usermessage
                    Dim title = Application.ProductName
                    Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.Critical
                    Dim response = MsgBox(msg, style, title)
                    If response = MsgBoxResult.Yes Then
                        main.ApplicationRestart()
                    ElseIf response = MsgBoxResult.No Then
                        'main.ApplicationShutdown()
                        main.btnExit.Enabled = True
                        main.btnHide.Enabled = True
                    End If
                ElseIf errorType = MsgBoxStyle.Exclamation Then
                    Dim msg = usermessage
                    Dim title = Application.ProductName
                    Dim style = MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation
                    Dim response = MsgBox(msg, style, title)
                    If response = MsgBoxResult.Ok Then
                        'nothing
                        main.btnExit.Enabled = True
                        main.btnHide.Enabled = True
                    End If
                End If
            End If 'END SILENT MODE
            main.tsslStatus.Text = "Ready."
        Catch ex As Exception
            errorHandlerProblem("MSGBOX", ex.Message(), ex.StackTrace())
        End Try
    End Sub
    Public Shared Sub errorHandlerProblem(type As String, exMessage As String, exStackTrace As String)
        'LOG FILE
        If System.IO.Directory.Exists(main.logsFilePath) = False Then
            System.IO.Directory.CreateDirectory(main.logsFilePath)
        End If
        IO.File.WriteAllText(main.logsFilePath & DateTime.Now.ToString("dd-MM-yyyy-HH_mm_ss") & ".log", type & " PROBLEM: " & exMessage _
                             & vbNewLine & vbNewLine & exStackTrace)
        main.tsslStatus.Text = "Log files saved."
        main.ApplicationShutdown()
    End Sub
End Class