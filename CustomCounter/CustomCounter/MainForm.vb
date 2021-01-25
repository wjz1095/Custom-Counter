Public Class MainForm


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

    Private Sub ClearAllItems()
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
        Counter11Label.Text = "0"
        Counter12Label.Text = "0"

        'Set all counts to 0
        Counter1Count = 0
        Counter2Count = 0
        Counter3Count = 0
        Counter4Count = 0
        Counter5Count = 0
        Counter6Count = 0
        Counter7Count = 0
        Counter8Count = 0
        Counter9Count = 0
        Counter10Count = 0
        Counter11Count = 0
        Counter12Count = 0
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Main loading of the form
        ClearAllItems()

    End Sub

    'Closing confirmation dialog
    Private Sub MainForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MessageBox.Show("Are you sure you want to close the counter?", "Counter Close Confirmation", MessageBoxButtons.YesNo) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    'Form elements below

    Private Sub Counter1ResetButton_Click(sender As Object, e As EventArgs) Handles Counter1ResetButton.Click
        Counter1TextBox.Text = ""
        Counter1Count = 0
    End Sub

    Private Sub Counter2ResetButton_Click(sender As Object, e As EventArgs) Handles Counter2ResetButton.Click
        Counter2TextBox.Text = ""
        Counter2Count = 0
    End Sub

    Private Sub Counter3ResetButton_Click(sender As Object, e As EventArgs) Handles Counter3ResetButton.Click
        Counter3TextBox.Text = ""
        Counter3Count = 0
    End Sub

    Private Sub Counter4ResetButton_Click(sender As Object, e As EventArgs) Handles Counter4ResetButton.Click
        Counter4TextBox.Text = ""
        Counter4Count = 0
    End Sub

    Private Sub Counter5ResetButton_Click(sender As Object, e As EventArgs) Handles Counter5ResetButton.Click
        Counter5TextBox.Text = ""
        Counter5Count = 0
    End Sub

    Private Sub Counter6ResetButton_Click(sender As Object, e As EventArgs) Handles Counter6ResetButton.Click
        Counter6TextBox.Text = ""
        Counter6Count = 0
    End Sub

    Private Sub Counter7ResetButton_Click(sender As Object, e As EventArgs) Handles Counter7ResetButton.Click
        Counter7TextBox.Text = ""
        Counter7Count = 0
    End Sub

    Private Sub Counter8ResetButton_Click(sender As Object, e As EventArgs) Handles Counter8ResetButton.Click
        Counter8TextBox.Text = ""
        Counter8Count = 0
    End Sub

    Private Sub Counter9ResetButton_Click(sender As Object, e As EventArgs) Handles Counter9ResetButton.Click
        Counter9TextBox.Text = ""
        Counter9Count = 0
    End Sub

    Private Sub Counter10ResetButton_Click(sender As Object, e As EventArgs) Handles Counter10ResetButton.Click
        Counter10TextBox.Text = ""
        Counter10Count = 0
    End Sub

    Private Sub Counter11ResetButton_Click(sender As Object, e As EventArgs) Handles Counter11ResetButton.Click
        Counter11TextBox.Text = ""
        Counter11Count = 0
    End Sub

    Private Sub Counter12ResetButton_Click(sender As Object, e As EventArgs) Handles Counter12ResetButton.Click
        Counter12TextBox.Text = ""
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

    Private Sub Counter1SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter1SetTo0Button.Click
        Counter1Label.Text = "0"
        Counter1Count = 0
    End Sub

    Private Sub Counter2SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter2SetTo0Button.Click
        Counter2Label.Text = "0"
        Counter2Count = 0
    End Sub

    Private Sub Counter3SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter3SetTo0Button.Click
        Counter3Label.Text = "0"
        Counter3Count = 0
    End Sub

    Private Sub Counter4SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter4SetTo0Button.Click
        Counter4Label.Text = "0"
        Counter4Count = 0
    End Sub

    Private Sub Counter5SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter5SetTo0Button.Click
        Counter5Label.Text = "0"
        Counter5Count = 0
    End Sub

    Private Sub Counter6SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter6SetTo0Button.Click
        Counter6Label.Text = "0"
        Counter6Count = 0
    End Sub

    Private Sub Counter7SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter7SetTo0Button.Click
        Counter7Label.Text = "0"
        Counter7Count = 0
    End Sub

    Private Sub Counter8SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter8SetTo0Button.Click
        Counter8Label.Text = "0"
        Counter8Count = 0
    End Sub

    Private Sub Counter9SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter9SetTo0Button.Click
        Counter9Label.Text = "0"
        Counter9Count = 0
    End Sub

    Private Sub Counter10SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter10SetTo0Button.Click
        Counter10Label.Text = "0"
        Counter10Count = 0
    End Sub

    Private Sub Counter11SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter11SetTo0Button.Click
        Counter11Label.Text = "0"
        Counter11Count = 0
    End Sub

    Private Sub Counter12SetTo0Button_Click(sender As Object, e As EventArgs) Handles Counter12SetTo0Button.Click
        Counter12Label.Text = "0"
        Counter12Count = 0
    End Sub

    Private Sub ResetAllButton_Click(sender As Object, e As EventArgs) Handles ResetAllButton.Click
        'Confirm with user that they want to reset all
        If MessageBox.Show("Are you sure you want to reset everything?", "Reset Confirmation", MessageBoxButtons.YesNo) = DialogResult.No Then
            'If dialog is NO, do nothing

        Else 'If dialog is YES, clear form
            ClearAllItems()
        End If

    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click

        'Get file path save location
        Dim CSVExportLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & Me.Text & ".csv"

        'Opens folder browser dialog and asks the user where they want their data saved to
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            CSVExportLocation = FolderBrowserDialog1.SelectedPath & "\" & Me.Text & ".csv"
        End If

        'Create datatable
        Dim ExportTable As New DataTable

        ' Create columns in the DataTable
        ExportTable.Columns.Add("CounterText", GetType(String))
        ExportTable.Columns.Add("CounterValue", GetType(String))

        'Get time and date
        Dim DateNow = System.DateTime.Now
        DateNow.ToString("yyyy-MM-dd HH:mm:ss")

        ' Add our data to the table
        ExportTable.Rows.Add("Counter Text", "Counter Value") 'Add column names
        ExportTable.Rows.Add(Me.Text, DateNow) 'Add form title and current date to table
        ExportTable.Rows.Add(Counter1TextBox.Text, Counter1Count)
        ExportTable.Rows.Add(Counter2TextBox.Text, Counter2Count)
        ExportTable.Rows.Add(Counter3TextBox.Text, Counter3Count)
        ExportTable.Rows.Add(Counter4TextBox.Text, Counter4Count)
        ExportTable.Rows.Add(Counter5TextBox.Text, Counter5Count)
        ExportTable.Rows.Add(Counter6TextBox.Text, Counter6Count)
        ExportTable.Rows.Add(Counter7TextBox.Text, Counter7Count)
        ExportTable.Rows.Add(Counter8TextBox.Text, Counter8Count)
        ExportTable.Rows.Add(Counter9TextBox.Text, Counter9Count)
        ExportTable.Rows.Add(Counter10TextBox.Text, Counter10Count)
        ExportTable.Rows.Add(Counter11TextBox.Text, Counter11Count)
        ExportTable.Rows.Add(Counter12TextBox.Text, Counter12Count)

        Dim lines() As String = Array.ConvertAll(ExportTable.Rows.Cast(Of DataRow).ToArray, Function(dr) String.Join(",", Array.ConvertAll(dr.ItemArray, Function(o) o.ToString)))
        IO.File.WriteAllLines(CSVExportLocation, lines)

        'Clear data table once written to free memory
        ExportTable.Rows.Clear()

        Dim MsgBoxText As String = "File exported to: " & CSVExportLocation

        MessageBox.Show(MsgBoxText, "File Exported", MessageBoxButtons.OK)

    End Sub

    Private Sub SetTitleTextButton_Click(sender As Object, e As EventArgs) Handles SetTitleTextButton.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim TitleText1 As String

        TitleText1 = InputBox("Enter title text", "Title Text")
        Me.Text = TitleText1
    End Sub

End Class
