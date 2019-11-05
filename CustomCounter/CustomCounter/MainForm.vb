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

    'Create counter variables and set all to 0. Defined globally so all buttons can interact with the variables
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

    Private Sub Counter1ResetButton_Click(sender As Object, e As EventArgs) Handles Counter1ResetButton.Click
        Counter1TextBox.Text = ""
        Counter1Label.Text = "0"
        Counter1Count = 0
    End Sub

    Private Sub Counter2ResetButton_Click(sender As Object, e As EventArgs) Handles Counter2ResetButton.Click
        Counter2TextBox.Text = ""
        Counter2Label.Text = "0"
        Counter2Count = 0
    End Sub

    Private Sub Counter3ResetButton_Click(sender As Object, e As EventArgs) Handles Counter3ResetButton.Click
        Counter3TextBox.Text = ""
        Counter3Label.Text = "0"
        Counter3Count = 0
    End Sub

    Private Sub Counter4ResetButton_Click(sender As Object, e As EventArgs) Handles Counter4ResetButton.Click
        Counter4TextBox.Text = ""
        Counter4Label.Text = "0"
        Counter4Count = 0
    End Sub

    Private Sub Counter5ResetButton_Click(sender As Object, e As EventArgs) Handles Counter5ResetButton.Click
        Counter5TextBox.Text = ""
        Counter5Label.Text = "0"
        Counter5Count = 0
    End Sub

    Private Sub Counter6ResetButton_Click(sender As Object, e As EventArgs) Handles Counter6ResetButton.Click
        Counter6TextBox.Text = ""
        Counter6Label.Text = "0"
        Counter6Count = 0
    End Sub

    Private Sub Counter7ResetButton_Click(sender As Object, e As EventArgs) Handles Counter7ResetButton.Click
        Counter7TextBox.Text = ""
        Counter7Label.Text = "0"
        Counter7Count = 0
    End Sub

    Private Sub Counter8ResetButton_Click(sender As Object, e As EventArgs) Handles Counter8ResetButton.Click
        Counter8TextBox.Text = ""
        Counter8Label.Text = "0"
        Counter8Count = 0
    End Sub

    Private Sub Counter9ResetButton_Click(sender As Object, e As EventArgs) Handles Counter9ResetButton.Click
        Counter9TextBox.Text = ""
        Counter9Label.Text = "0"
        Counter9Count = 0
    End Sub

    Private Sub Counter10ResetButton_Click(sender As Object, e As EventArgs) Handles Counter10ResetButton.Click
        Counter10TextBox.Text = ""
        Counter10Label.Text = "0"
        Counter10Count = 0
    End Sub

    Private Sub Counter11ResetButton_Click(sender As Object, e As EventArgs) Handles Counter11ResetButton.Click
        Counter11TextBox.Text = ""
        Counter11Label.Text = "0"
        Counter11Count = 0
    End Sub

    Private Sub Counter12ResetButton_Click(sender As Object, e As EventArgs) Handles Counter12ResetButton.Click
        Counter12TextBox.Text = ""
        Counter12Label.Text = "0"
        Counter12Count = 0
    End Sub

    Public Sub Counter1MinusButton_Click(sender As Object, e As EventArgs) Handles Counter1MinusButton.Click
        Counter1Count = Counter1Count - 1
        Counter1Label.Text = Counter1Count
    End Sub

    Private Sub Counter1PlusButton_Click(sender As Object, e As EventArgs) Handles Counter1PlusButton.Click
        Counter1Count = Counter1Count + 1
        Counter1Label.Text = Counter1Count
    End Sub

    Private Sub Counter2MinusButton_Click(sender As Object, e As EventArgs) Handles Counter2MinusButton.Click
        Counter2Count = Counter2Count - 1
        Counter2Label.Text = Counter2Count
    End Sub

    Private Sub Counter2PlusButton_Click(sender As Object, e As EventArgs) Handles Counter2PlusButton.Click
        Counter2Count = Counter2Count + 1
        Counter2Label.Text = Counter2Count
    End Sub

    Private Sub Counter3MinusButton_Click(sender As Object, e As EventArgs) Handles Counter3MinusButton.Click
        Counter3Count = Counter3Count - 1
        Counter3Label.Text = Counter3Count
    End Sub

    Private Sub Counter3PlusButton_Click(sender As Object, e As EventArgs) Handles Counter3PlusButton.Click
        Counter3Count = Counter3Count + 1
        Counter3Label.Text = Counter3Count
    End Sub

    Private Sub Counter4MinusButton_Click(sender As Object, e As EventArgs) Handles Counter4MinusButton.Click
        Counter4Count = Counter4Count - 1
        Counter4Label.Text = Counter4Count
    End Sub

    Private Sub Counter4PlusButton_Click(sender As Object, e As EventArgs) Handles Counter4PlusButton.Click
        Counter4Count = Counter4Count + 1
        Counter4Label.Text = Counter4Count
    End Sub

    Private Sub Counter5MinusButton_Click(sender As Object, e As EventArgs) Handles Counter5MinusButton.Click
        Counter5Count = Counter5Count - 1
        Counter5Label.Text = Counter5Count
    End Sub

    Private Sub Counter5PlusButton_Click(sender As Object, e As EventArgs) Handles Counter5PlusButton.Click
        Counter5Count = Counter5Count + 1
        Counter5Label.Text = Counter5Count
    End Sub

    Private Sub Counter6MinusButton_Click(sender As Object, e As EventArgs) Handles Counter6MinusButton.Click
        Counter6Count = Counter6Count - 1
        Counter6Label.Text = Counter6Count
    End Sub

    Private Sub Counter6PlusButton_Click(sender As Object, e As EventArgs) Handles Counter6PlusButton.Click
        Counter6Count = Counter6Count + 1
        Counter6Label.Text = Counter6Count
    End Sub

    Private Sub Counter7MinusButton_Click(sender As Object, e As EventArgs) Handles Counter7MinusButton.Click
        Counter7Count = Counter7Count - 1
        Counter7Label.Text = Counter7Count
    End Sub

    Private Sub Counter7PlusButton_Click(sender As Object, e As EventArgs) Handles Counter7PlusButton.Click
        Counter7Count = Counter7Count + 1
        Counter7Label.Text = Counter7Count
    End Sub

    Private Sub Counter8MinusButton_Click(sender As Object, e As EventArgs) Handles Counter8MinusButton.Click
        Counter8Count = Counter8Count - 1
        Counter8Label.Text = Counter8Count
    End Sub

    Private Sub Counter8PlusButton_Click(sender As Object, e As EventArgs) Handles Counter8PlusButton.Click
        Counter8Count = Counter8Count + 1
        Counter8Label.Text = Counter8Count
    End Sub

    Private Sub Counter9MinusButton_Click(sender As Object, e As EventArgs) Handles Counter9MinusButton.Click
        Counter9Count = Counter9Count - 1
        Counter9Label.Text = Counter9Count
    End Sub

    Private Sub Counter9PlusButton_Click(sender As Object, e As EventArgs) Handles Counter9PlusButton.Click
        Counter9Count = Counter9Count + 1
        Counter9Label.Text = Counter9Count
    End Sub

    Private Sub Counter10MinusButton_Click(sender As Object, e As EventArgs) Handles Counter10MinusButton.Click
        Counter10Count = Counter10Count - 1
        Counter10Label.Text = Counter10Count
    End Sub

    Private Sub Counter10PlusButton_Click(sender As Object, e As EventArgs) Handles Counter10PlusButton.Click
        Counter10Count = Counter10Count + 1
        Counter10Label.Text = Counter10Count
    End Sub

    Private Sub Counter11MinusButton_Click(sender As Object, e As EventArgs) Handles Counter11MinusButton.Click
        Counter11Count = Counter11Count - 1
        Counter11Label.Text = Counter11Count
    End Sub

    Private Sub Counter11PlusButton_Click(sender As Object, e As EventArgs) Handles Counter11PlusButton.Click
        Counter11Count = Counter11Count + 1
        Counter11Label.Text = Counter11Count
    End Sub

    Private Sub Counter12MinusButton_Click(sender As Object, e As EventArgs) Handles Counter12MinusButton.Click
        Counter12Count = Counter12Count - 1
        Counter12Label.Text = Counter12Count
    End Sub

    Private Sub Counter12PlusButton_Click(sender As Object, e As EventArgs) Handles Counter12PlusButton.Click
        Counter12Count = Counter12Count + 1
        Counter12Label.Text = Counter12Count
    End Sub
End Class
