Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        For index = 1 To 10
            Beep()
            Threading.Thread.Sleep(3000)
        Next
    End Sub
End Class
