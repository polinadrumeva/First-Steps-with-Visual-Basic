Public Class ArraysExercises

    'Class-level array – accessible to all methods
    Dim arrNumber(4) As Integer
    Dim i As Integer

    'Constructor
    Public Sub New()
        'This calls InitializeComponent to load the form components.
        InitializeComponent()

        'Array initialization
        arrNumber(0) = 5
        arrNumber(1) = 7
        arrNumber(2) = 45
        arrNumber(3) = 18
        arrNumber(4) = 59
    End Sub

    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click
        For i = 0 To arrNumber.Length - 1
            MessageBox.Show("Current number is: " & arrNumber(i))
        Next
    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click

        Dim strOutput As String = ""

        For i = 0 To arrNumber.Length - 1
            strOutput += arrNumber(i) & vbNewLine
        Next

        MessageBox.Show("All numbers are: " & vbNewLine & strOutput)
    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

        Dim sum As Integer

        For i = 0 To arrNumber.Length - 1
            sum += arrNumber(i)
        Next

        MessageBox.Show("Total sum is: " & sum)

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

        Dim sum As Integer

        For i = 0 To arrNumber.Length - 1
            sum += arrNumber(i)
        Next

        sum /= 2

        MessageBox.Show("Average sum is: " & sum)

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click

    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

    End Sub


End Class
