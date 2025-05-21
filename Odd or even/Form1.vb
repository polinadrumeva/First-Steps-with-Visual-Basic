Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        Dim number As Integer
        Dim var As String
        Dim x As Integer

        number = InputBox("What number do you want to count up to?")
        var = InputBox("Do you want odd numbers ot even numbers?")

        If var = "even" Then
            For x = 2 To number Step 2
                MessageBox.Show(x)
            Next
        ElseIf var = "odd" Then
            For x = 1 To number Step 2
                MessageBox.Show(x)

            Next
        Else
            MessageBox.Show("Please enter valid type!")


        End If



    End Sub
End Class
