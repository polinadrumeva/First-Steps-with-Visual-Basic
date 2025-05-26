Public Class Form1

    Dim arPeople(4, 3) As String

    Sub New()

        InitializeComponent()

        arPeople(0, 0) = "Barak"
        arPeople(1, 0) = "Obama"
        arPeople(2, 0) = "Male"
        arPeople(3, 0) = "American"
        arPeople(4, 0) = "President"

        arPeople(0, 1) = "Ada"
        arPeople(1, 1) = "Lovelace"
        arPeople(2, 1) = "Female"
        arPeople(3, 1) = "British"
        arPeople(4, 1) = "Mathematician"

        arPeople(0, 2) = "Albert"
        arPeople(1, 2) = "Einstein"
        arPeople(2, 2) = "Male"
        arPeople(3, 2) = "Swish"
        arPeople(4, 2) = "Scientist"

        arPeople(0, 3) = "Vincent"
        arPeople(1, 3) = "van Gogh"
        arPeople(2, 3) = "Male"
        arPeople(3, 3) = "Dutch"
        arPeople(4, 3) = "Artist"


    End Sub

    Private Sub btnRowWise_Click(sender As Object, e As EventArgs) Handles btnRowWise.Click

        For x = 0 To 3
            For y = 0 To 4
                MessageBox.Show(arPeople(y, x))
            Next
        Next


    End Sub

    Private Sub btnColWise_Click(sender As Object, e As EventArgs) Handles btnColWise.Click
        For x = 0 To 4
            For y = 0 To 3
                MessageBox.Show(arPeople(x, y))
            Next
        Next
    End Sub
End Class
