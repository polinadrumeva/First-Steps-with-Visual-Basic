Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim iCount As Integer

        'Difference between position in loop statement

        'Do While
        Do While iCount < 5
            MessageBox.Show("Hello " & iCount)
            iCount += 1
        Loop

        iCount = 0
        Do
            MessageBox.Show("Hello " & iCount)
            iCount += 1
        Loop While iCount = 5


        'Do Until
        iCount = 0
        Do Until iCount <= 5
            MessageBox.Show("Hello " & iCount)
            iCount += 1
        Loop

        iCount = 0
        Do
            MessageBox.Show("Hello " & iCount)
            iCount += 1
        Loop Until iCount = 5
    End Sub
End Class
