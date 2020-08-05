Public Class mini
    Dim saveInt As Integer = 0
    Private Sub mini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Clip " & main.clipMiniVersion & " - Mini"
        main.btnSave.Enabled = False
    End Sub

    Private Sub lbMini_DoubleClick(sender As Object, e As EventArgs) Handles lbMini.DoubleClick
        Try
            Clipboard.SetDataObject(lbMini.SelectedItem.ToString, True, 20, 50)
            main.tsslStatus.Text = "Text copied to the clipboard."
            Dim sw As New Stopwatch
            sw.Start()
            Do While sw.ElapsedMilliseconds < 2000
                Application.DoEvents() 'Allows UI to remain responsive
                Me.Text = "Text copied!"
            Loop
            sw.Stop()
            Me.Text = "Clip " & main.clipMiniVersion & " - Mini"
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub mini_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        main.btnSave.Enabled = True
        saveInt = 0 'Reset timer
        tMiniSave.Start()
    End Sub

    Private Sub mini_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        main.btnSave.Enabled = True
        saveInt = 0 'Reset timer
        tMiniSave.Start()
    End Sub

    Private Sub tMiniSave_Tick(sender As Object, e As EventArgs) Handles tMiniSave.Tick
        saveInt = saveInt + 1
        If saveInt = 10 Then
            main.SaveSettings()
            tMiniSave.Stop()
            main.btnSave.Enabled = False
        End If
        main.tsslStatus.Text = "Settings saved."
    End Sub

    Private Sub ClearAllHistoryInMiniWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllHistoryInMiniWindowToolStripMenuItem.Click
        Try
            lbMini.Items.Clear()
        Catch ex As Exception
            ErrorHandler.reportError(ex.Message(), ex.StackTrace(), MsgBoxStyle.Critical)
        End Try
    End Sub
End Class