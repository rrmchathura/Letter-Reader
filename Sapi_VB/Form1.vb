Public Class Form1
    Dim Sapi
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Sapi = CreateObject("Sapi.spvoice")

        Sapi.speak(txtSpeak.Text, 1)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Sapi.pause
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSpeak.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        Sapi.resume
    End Sub
End Class
