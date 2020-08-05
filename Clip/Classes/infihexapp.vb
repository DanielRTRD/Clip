Imports System.Security.Principal

Public Class infihexapp
    Public Shared filesFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Infihex\" _
                                              & System.Reflection.Assembly.GetEntryAssembly().GetName().Name & "\"
    Public Shared logsFilePath As String = filesFolderPath & "\logs\"
    Public Shared logFileName As String = logsFilePath & DateTime.Now.ToString("dd-MM-yyyy") & ".log"
    Public Shared tempFilePath As String = System.AppDomain.CurrentDomain.BaseDirectory & "\temp\"
    Public Shared settingsFilePath As String = filesFolderPath & "settings.ini"
    Public Shared ProductName As String = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
    Public Shared longVersion As String = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." _
                                            & My.Application.Info.Version.Build.ToString & " Build " & My.Application.Info.Version.Revision.ToString
    Public Shared shortVersion As String = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." _
                                            & My.Application.Info.Version.Build.ToString
    Public Shared miniVersion As String = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString

    Public Shared Sub ApplicationShutdown()
        Try
            infihexlog.logThis("INFO", "Application is shutting down.")
            Application.Exit()
        Catch ex As Exception
            infihexerror.reportError(ex.Message(), ex.StackTrace())
        End Try
    End Sub
    Public Shared Sub ApplicationRestart()
        Try
            infihexlog.logThis("INFO", "Application shutting down...")
            Application.Exit()
            infihexlog.logThis("INFO", "Application is trying to restart: " & Application.ExecutablePath)
            Process.Start(Application.ExecutablePath)
        Catch ex As Exception
            infihexerror.reportError(ex.Message(), ex.StackTrace())
        End Try
    End Sub

    Public Shared Function isElevated()
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)
        Dim isRunAsAdmin As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
        Return isRunAsAdmin
    End Function
End Class
