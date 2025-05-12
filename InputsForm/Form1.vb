Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ''INPUT IN MESSAGE BOX
        ' Dim stFirstName As String

        ' stFirstName = InputBox("Please enter your First name:")

        ' MessageBox.Show("Hello, " & stFirstName & "!")

        '' INPUT 
        Dim strFirstName As String
        Dim strLastName As String
        Dim strGender As String

        strFirstName = txtFIrstName.Text
        strLastName = txtLastName.Text
        strGender = txtGender.Text

        MessageBox.Show("Hello, " & strFirstName & " " & strLastName & vbNewLine &
                        "You are " & strGender)

    End Sub
End Class
