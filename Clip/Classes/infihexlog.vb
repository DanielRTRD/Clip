Public Class infihexlog
    Public Shared Sub logThis(type As String, text As String)

        If type = Nothing Then
            type = "INFO"
        End If
        type = type.ToUpper()
        text = text.Replace(vbNewLine, "") 'Remove new lines if present

        If Not IO.Directory.Exists(infihexapp.logsFilePath) Then
            IO.Directory.CreateDirectory(infihexapp.logsFilePath)
        End If

        Dim OSBit As String
        If Environment.Is64BitOperatingSystem = True Then
            OSBit = " 64-Bit"
        Else
            OSBit = " 32-Bit"
        End If

        Dim LogComputerInfo As String
        LogComputerInfo = infihexapp.ProductName & " - " & infihexapp.longVersion & vbNewLine &
                    "========================================" & vbNewLine &
                    "Date and Time: " & DateTime.Now.ToString("dd. MMMM yyyy - HH:mm:ss") & vbNewLine &
                    "Domain: " & Environment.UserDomainName & vbNewLine &
                    "Username: " & Environment.UserName & vbNewLine &
                    "Computername: " & Environment.MachineName & vbNewLine &
                    "Windows: " & My.Computer.Info.OSFullName & OSBit & " (" & My.Computer.Info.OSVersion & ")" & vbNewLine &
                    "========================================" & vbNewLine

        If Not IO.File.Exists(infihexapp.logFileName) Then
            IO.File.WriteAllText(infihexapp.logFileName, LogComputerInfo)
        End If

        Using writer As New IO.StreamWriter(infihexapp.logFileName, True)
            writer.WriteLine(DateTime.Now.ToString("HH:mm:ss") & " - " & type & " - " & text)
        End Using

    End Sub
End Class
