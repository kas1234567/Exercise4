Public Class Form1
    'create a program that uses nested loop to display multiplcation table 1-10
    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Dim i As Integer = 1
        Dim j As Integer = 1

        While (i <= 10)
            j = 1
            While (j <= 10)
                lstBox.Items.Add(i & "X" & j & "=" & (i * j))
                j += 1
            End While
            i += 1
        End While
    End Sub


End Class
