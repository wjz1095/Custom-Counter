Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set all text boxes to blank
        Counter1TextBox.Text = ""
        Counter2TextBox.Text = ""
        Counter3TextBox.Text = ""
        Counter4TextBox.Text = ""
        Counter5TextBox.Text = ""
        Counter6TextBox.Text = ""
        Counter7TextBox.Text = ""
        Counter8TextBox.Text = ""
        Counter9TextBox.Text = ""
        Counter10TextBox.Text = ""
        Counter11TextBox.Text = ""
        Counter12TextBox.Text = ""

        'Set all labels to 0
        Counter1Label.Text = "0"
        Counter2Label.Text = "0"
        Counter3Label.Text = "0"
        Counter4Label.Text = "0"
        Counter5Label.Text = "0"
        Counter6Label.Text = "0"
        Counter7Label.Text = "0"
        Counter8Label.Text = "0"
        Counter9Label.Text = "0"
        Counter10Label.Text = "0"
        Counter12Label.Text = "0"

    End Sub

    Private Sub Counter1ResetButton_Click(sender As Object, e As EventArgs) Handles Counter1ResetButton.Click
        Counter1TextBox.Text = ""
        Counter1Label.Text = "0"
    End Sub

    Private Sub Counter2ResetButton_Click(sender As Object, e As EventArgs) Handles Counter2ResetButton.Click
        Counter2TextBox.Text = ""
        Counter2Label.Text = "0"
    End Sub

    Private Sub Counter3ResetButton_Click(sender As Object, e As EventArgs) Handles Counter3ResetButton.Click
        Counter3TextBox.Text = ""
        Counter3Label.Text = "0"
    End Sub

    Private Sub Counter4ResetButton_Click(sender As Object, e As EventArgs) Handles Counter4ResetButton.Click
        Counter4TextBox.Text = ""
        Counter4Label.Text = "0"
    End Sub

    Private Sub Counter5ResetButton_Click(sender As Object, e As EventArgs) Handles Counter5ResetButton.Click
        Counter5TextBox.Text = ""
        Counter5Label.Text = "0"
    End Sub

    Private Sub Counter6ResetButton_Click(sender As Object, e As EventArgs) Handles Counter6ResetButton.Click
        Counter6TextBox.Text = ""
        Counter6Label.Text = "0"
    End Sub

    Private Sub Counter7ResetButton_Click(sender As Object, e As EventArgs) Handles Counter7ResetButton.Click
        Counter7TextBox.Text = ""
        Counter7Label.Text = "0"
    End Sub

    Private Sub Counter8ResetButton_Click(sender As Object, e As EventArgs) Handles Counter8ResetButton.Click
        Counter8TextBox.Text = ""
        Counter8Label.Text = "0"
    End Sub

    Private Sub Counter9ResetButton_Click(sender As Object, e As EventArgs) Handles Counter9ResetButton.Click
        Counter9TextBox.Text = ""
        Counter9Label.Text = "0"
    End Sub

    Private Sub Counter10ResetButton_Click(sender As Object, e As EventArgs) Handles Counter10ResetButton.Click
        Counter10TextBox.Text = ""
        Counter10Label.Text = "0"
    End Sub

    Private Sub Counter11ResetButton_Click(sender As Object, e As EventArgs) Handles Counter11ResetButton.Click
        Counter11TextBox.Text = ""
        Counter11Label.Text = "0"
    End Sub

    Private Sub Counter12ResetButton_Click(sender As Object, e As EventArgs) Handles Counter12ResetButton.Click
        Counter12TextBox.Text = ""
        Counter12Label.Text = "0"
    End Sub
End Class
