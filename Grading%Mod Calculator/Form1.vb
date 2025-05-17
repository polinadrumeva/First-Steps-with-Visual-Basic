Public Class Form1
    Private Sub btnGrading_Click(sender As Object, e As EventArgs) Handles btnGrading.Click

        Dim number As Decimal
        Dim gradeNumber As Decimal
        Dim resultGrading As Decimal

        If IsNumeric(txtNumber.Text) = False Or IsNumeric(txtGradeNumber.Text) = False Then
            MessageBox.Show("Грешка! Моля въведете число!")
            txtNumber.Clear()
            txtGradeNumber.Clear()

        Else
            number = txtNumber.Text
            gradeNumber = txtGradeNumber.Text

        End If

        resultGrading = number ^ gradeNumber

        txtResultGrading.ReadOnly = True
        txtResultGrading.Text = resultGrading


    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click

    End Sub


End Class
