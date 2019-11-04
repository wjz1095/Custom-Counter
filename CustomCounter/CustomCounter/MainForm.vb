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

        'Create counter variables and set all to 0
        Dim Counter1Count As Integer = 0
        Dim Counter2Count As Integer = 0
        Dim Counter3Count As Integer = 0
        Dim Counter4Count As Integer = 0
        Dim Counter5Count As Integer = 0
        Dim Counter6Count As Integer = 0
        Dim Counter7Count As Integer = 0
        Dim Counter8Count As Integer = 0
        Dim Counter9Count As Integer = 0
        Dim Counter10Count As Integer = 0
        Dim Counter11Count As Integer = 0
        Dim Counter12Count As Integer = 0
    End Sub

    Public Module DefineVariables
        Public Counter1Count As Integer = 0

    End Module


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

    Public Sub Counter1MinusButton_Click(sender As Object, e As EventArgs) Handles Counter1MinusButton.Click
        Counter1Count = Counter1Count - 1

    End Sub

    Private Sub Counter1PlusButton_Click(sender As Object, e As EventArgs) Handles Counter1PlusButton.Click

    End Sub

    Private Sub Counter2MinusButton_Click(sender As Object, e As EventArgs) Handles Counter2MinusButton.Click

    End Sub

    Private Sub Counter2PlusButton_Click(sender As Object, e As EventArgs) Handles Counter2PlusButton.Click

    End Sub

    Private Sub Counter3MinusButton_Click(sender As Object, e As EventArgs) Handles Counter3MinusButton.Click

    End Sub

    Private Sub Counter3PlusButton_Click(sender As Object, e As EventArgs) Handles Counter3PlusButton.Click

    End Sub

    Private Sub Counter4MinusButton_Click(sender As Object, e As EventArgs) Handles Counter4MinusButton.Click

    End Sub

    Private Sub Counter4PlusButton_Click(sender As Object, e As EventArgs) Handles Counter4PlusButton.Click

    End Sub

    Private Sub Counter5MinusButton_Click(sender As Object, e As EventArgs) Handles Counter5MinusButton.Click

    End Sub

    Private Sub Counter5PlusButton_Click(sender As Object, e As EventArgs) Handles Counter5PlusButton.Click

    End Sub

    Private Sub Counter6MinusButton_Click(sender As Object, e As EventArgs) Handles Counter6MinusButton.Click

    End Sub

    Private Sub Counter6PlusButton_Click(sender As Object, e As EventArgs) Handles Counter6PlusButton.Click

    End Sub

    Private Sub Counter7MinusButton_Click(sender As Object, e As EventArgs) Handles Counter7MinusButton.Click

    End Sub

    Private Sub Counter7PlusButton_Click(sender As Object, e As EventArgs) Handles Counter7PlusButton.Click

    End Sub


    Private Sub Counter8MinusButton_Click(sender As Object, e As EventArgs) Handles Counter8MinusButton.Click

    End Sub

    Private Sub Counter8PlusButton_Click(sender As Object, e As EventArgs) Handles Counter8PlusButton.Click

    End Sub

    Private Sub Counter9MinusButton_Click(sender As Object, e As EventArgs) Handles Counter9MinusButton.Click

    End Sub

    Private Sub Counter9PlusButton_Click(sender As Object, e As EventArgs) Handles Counter9PlusButton.Click

    End Sub

    Private Sub Counter10MinusButton_Click(sender As Object, e As EventArgs) Handles Counter10MinusButton.Click

    End Sub

    Private Sub Counter10PlusButton_Click(sender As Object, e As EventArgs) Handles Counter10PlusButton.Click

    End Sub

    Private Sub Counter11MinusButton_Click(sender As Object, e As EventArgs) Handles Counter11MinusButton.Click

    End Sub

    Private Sub Counter11PlusButton_Click(sender As Object, e As EventArgs) Handles Counter11PlusButton.Click

    End Sub

    Private Sub Counter12MinusButton_Click(sender As Object, e As EventArgs) Handles Counter12MinusButton.Click

    End Sub

    Private Sub Counter12PlusButton_Click(sender As Object, e As EventArgs) Handles Counter12PlusButton.Click

    End Sub
End Class
