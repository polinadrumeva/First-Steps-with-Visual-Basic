Public Class Form1

    Dim iNumber1 As Integer
    Dim iNumber2 As Integer
    Dim iResult As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 + iNumber2

        MessageBox.Show(iResult)

    End Sub

    Private Sub btnGrading_Click(sender As Object, e As EventArgs) Handles btnGrading.Click

        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 ^ iNumber2

        MessageBox.Show(iResult)
    End Sub
End Class
