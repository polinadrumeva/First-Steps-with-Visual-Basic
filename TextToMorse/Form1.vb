Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Threading


Public Class Form1

    ' Morse Code Dictionary
    Dim morseDict As New Dictionary(Of Char, String) From {
        {"A"c, ".-"}, {"B"c, "-..."}, {"C"c, "-.-."}, {"D"c, "-.."},
        {"E"c, "."}, {"F"c, "..-."}, {"G"c, "--."}, {"H"c, "...."},
        {"I"c, ".."}, {"J"c, ".---"}, {"K"c, "-.-"}, {"L"c, ".-.."},
        {"M"c, "--"}, {"N"c, "-."}, {"O"c, "---"}, {"P"c, ".--."},
        {"Q"c, "--.-"}, {"R"c, ".-."}, {"S"c, "..."}, {"T"c, "-"},
        {"U"c, "..-"}, {"V"c, "...-"}, {"W"c, ".--"}, {"X"c, "-..-"},
        {"Y"c, "-.--"}, {"Z"c, "--.."}, {"1"c, ".----"}, {"2"c, "..---"},
        {"3"c, "...--"}, {"4"c, "....-"}, {"5"c, "....."}, {"6"c, "-...."},
        {"7"c, "--..."}, {"8"c, "---.."}, {"9"c, "----."}, {"0"c, "-----"},
        {" "c, "/"}
    }

    ' Code function
    Function TextToMorse(text As String) As String

        Dim result As String = ""

        For Each ch As Char In text.ToUpper()
            If morseDict.ContainsKey(ch) Then
                result &= morseDict(ch) & " "
            End If
        Next

        Return result.Trim()

    End Function


    ' Decode function
    Function MorseToText(morse As String) As String

        Dim reverseDict = morseDict.ToDictionary(Function(k) k.Value, Function(k) k.Key)
        Dim parts = morse.Trim().Split(" "c)
        Dim result As String = ""

        For Each Part As String In parts
            If Part = "/" Then
                result &= " "
            ElseIf reverseDict.ContainsKey(Part) Then
                result &= reverseDict(Part)
            End If
        Next

        Return result

    End Function

    Sub PlayMorseSound(morseCode As String)
        For Each symbol As Char In morseCode
            Select Case symbol
                Case "."c
                    Console.Beep(800, 100)
                    Threading.Thread.Sleep(100)
                Case "-"c
                    Console.Beep(800, 300)
                    Threading.Thread.Sleep(100)
                Case " "c
                    Threading.Thread.Sleep(300)
                Case "/"c
                    Threading.Thread.Sleep(600)
            End Select
        Next
    End Sub

    Private Sub btnCode_Click(sender As Object, e As EventArgs) Handles btnCode.Click

        Dim inputText As String = txtOriginalText.Text
        Dim morseCode As String = TextToMorse(inputText)
        txtMorseCode.Text = morseCode


        PlayMorseSound(morseCode)

    End Sub

    Private Sub btnDecode_Click(sender As Object, e As EventArgs) Handles btnDecode.Click

        Dim morseInput As String = txtMorseCode.Text
        txtOriginalText.Text = MorseToText(morseInput)
    End Sub
End Class

