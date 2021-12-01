Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnErsterLink_Click(sender As Object, e As EventArgs) Handles btnErsterLink.Click
        tbErsterLink.Text = Replace("https://localhost:7771/", "localhost", tbNetzlaufwerk.Text & ".local")
        With tbErsterLink
            .SelectionStart = 0
            .SelectionLength = .TextLength
            .Copy()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tbZweiterLink.Text = Replace(tbNetzlaufwerk.Text, tbURL.Text, "localhost", tbNetzlaufwerk.Text & ".local")

        With tbZweiterLink
            .SelectionStart = 0
            .SelectionLength = .TextLength
            .Copy()
        End With
    End Sub
End Class
