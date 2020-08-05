Public Class infihexerror
    Public Shared Sub reportError(errorMessage As String, errorToString As String)
        Try

            MsgBox(errorMessage & vbNewLine & vbNewLine & errorToString, MsgBoxStyle.Critical & MsgBoxStyle.OkOnly, Application.ProductName)

        Catch ex As Exception

            infihexlog.logThis("ERROR", "LOG PROBLEMS:" & ex.Message & " - " & ex.ToString)

            infihexapp.ApplicationRestart()

        End Try

    End Sub
End Class
