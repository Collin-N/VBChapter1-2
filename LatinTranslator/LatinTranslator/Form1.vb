Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        lblTranslation.Visible = True
        lblTranslation.Text = ("Left")
        lblTranslation.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        lblTranslation.Visible = True
        lblTranslation.Text = ("Center")
        lblTranslation.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        lblTranslation.Visible = True
        lblTranslation.Text = ("Right")
        lblTranslation.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub lblTranslation_Click(sender As Object, e As EventArgs) Handles lblTranslation.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
