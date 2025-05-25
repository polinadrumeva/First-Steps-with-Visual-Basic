Public Class Form1

    Dim fruits(9) As String

    Sub New()

        InitializeComponent()

        fruits(0) = "Apple"
        fruits(1) = "Mango"
        fruits(2) = "Pear"
        fruits(3) = "Cherry"
        fruits(4) = "Banana"
        fruits(5) = "Tomato"
        fruits(6) = "Lemon"
        fruits(7) = "Orange"
        fruits(8) = "Melon"
        fruits(9) = "Grape"

    End Sub

    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        Dim target As String
        Dim beFound As Boolean = False
        Dim i As Integer
        Dim iCount As Integer

        target = InputBox("Which fruit you are looking for?")
        For i = 0 To fruits.Length - 1
            If fruits(i).ToUpper = target.ToUpper Then
                beFound = True
            End If
        Next

        If beFound = True Then
            MessageBox.Show("Found it!")
        Else
            MessageBox.Show("Sorry, not found!")
        End If

    End Sub
End Class
