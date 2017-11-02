Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPunchLine.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSetUp.Click

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        Select Case lblSetUp.Text
            Case "SetUp"
                lblSetUp.Text = "How many programers does it take to change a lightbulb"
                lblPunchLine.Visible = False
                lblSetUp.Visible = True
            Case "How many programers does it take to change a lightbulb"
                lblSetUp.Text = "Why was the soldier pinned down"
                lblPunchLine.Visible = False

        End Select
    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        Select Case lblPunchLine.Text
            Case "Punchline"
                lblPunchLine.Text = "None. That's a hardware problem"
                lblPunchLine.Visible = True
            Case "None. That's a hardware problem"
                lblPunchLine.Text = "Becase he was under a tack"
                lblPunchLine.Visible = True

        End Select
    End Sub
End Class
