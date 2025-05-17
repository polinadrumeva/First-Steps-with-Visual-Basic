Imports System.Numerics

Public Class Form1
    Private Sub btnGrading_Click(sender As Object, e As EventArgs) Handles btnGrading.Click

        Dim number As Decimal
        Dim gradeNumber As Integer
        Dim resultGrading As BigInteger


        txtResultGrading.ReadOnly = True


        If IsNumeric(txtNumber.Text) = False Or IsNumeric(txtGradeNumber.Text) = False Then
            MessageBox.Show("Грешка! Моля въведете число!")
            txtNumber.Clear()
            txtGradeNumber.Clear()
            txtResultGrading.Clear()

        ElseIf Not Integer.TryParse(txtGradeNumber.Text, gradeNumber) Then
            MessageBox.Show("Степента трябва да е цяло число!")
            txtGradeNumber.Clear()
            txtResultGrading.Clear()
        Else
            number = txtNumber.Text
            gradeNumber = txtGradeNumber.Text

            resultGrading = number ^ gradeNumber

            txtResultGrading.Text = resultGrading.ToString()

        End If



    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim resultGrading As BigInteger
        Dim modNumber As Integer
        Dim resultMod As BigInteger


        txtModResult.ReadOnly = True

        If String.IsNullOrWhiteSpace(txtResultGrading.Text) Then
            MessageBox.Show("Моля първо изчислете степенуването!")
        ElseIf IsNumeric(txtModNumber.Text) = False Then
            MessageBox.Show("Грешка! Моля въведете число!")
            txtModNumber.Clear()
        ElseIf Integer.Parse(txtModNumber.Text) > BigInteger.Parse(txtResultGrading.Text) Then
            MessageBox.Show("Грешка! Невъзможно деление на " & txtModNumber.Text)
            txtModNumber.Clear()
        ElseIf Integer.Parse(txtModNumber.Text) = 0 Then
            MessageBox.Show("Грешка! Деление на нула не е позволено!")
            txtModNumber.Clear()

        Else
            resultGrading = txtResultGrading.Text
            modNumber = txtModNumber.Text

            resultMod = resultGrading Mod modNumber
            txtModResult.Text = resultMod.ToString()
        End If

    End Sub


End Class
