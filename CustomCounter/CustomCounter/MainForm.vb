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

    'Reset all items to original values
    Private Sub ClearAllItems()
        'Set all text boxes to blank
        Counter1GroupBox.Text = "Counter 1"
        Counter2GroupBox.Text = "Counter 2"
        Counter3GroupBox.Text = "Counter 3"
        Counter4GroupBox.Text = "Counter 4"
        Counter5GroupBox.Text = "Counter 5"
        Counter6GroupBox.Text = "Counter 6"
        Counter7GroupBox.Text = "Counter 7"
        Counter8GroupBox.Text = "Counter 8"
        Counter9GroupBox.Text = "Counter 9"

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
    End Sub

    'On main form load, perform the following actions
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

    'Export to a file
    Private Sub ExportButton_Click(sender As Object, e As EventArgs)

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

        'ExportTable.Rows.Add(Counter1TextBox.Text, Counter1Count)
        'ExportTable.Rows.Add(Counter2TextBox.Text, Counter2Count)
        'ExportTable.Rows.Add(Counter3TextBox.Text, Counter3Count)
        'ExportTable.Rows.Add(Counter4TextBox.Text, Counter4Count)
        'ExportTable.Rows.Add(Counter5TextBox.Text, Counter5Count)
        'ExportTable.Rows.Add(Counter6TextBox.Text, Counter6Count)
        'ExportTable.Rows.Add(Counter7TextBox.Text, Counter7Count)
        'ExportTable.Rows.Add(Counter8TextBox.Text, Counter8Count)
        'ExportTable.Rows.Add(Counter9TextBox.Text, Counter9Count)
        'ExportTable.Rows.Add(Counter10TextBox.Text, Counter10Count)
        'ExportTable.Rows.Add(Counter11TextBox.Text, Counter11Count)
        'ExportTable.Rows.Add(Counter12TextBox.Text, Counter12Count)

        Dim lines() As String = Array.ConvertAll(ExportTable.Rows.Cast(Of DataRow).ToArray, Function(dr) String.Join(",", Array.ConvertAll(dr.ItemArray, Function(o) o.ToString)))
        IO.File.WriteAllLines(CSVExportLocation, lines)

        'Clear data table once written to free memory
        ExportTable.Rows.Clear()

        Dim MsgBoxText As String = "File exported to: " & CSVExportLocation

        MessageBox.Show(MsgBoxText, "File Exported", MessageBoxButtons.OK)

    End Sub

    'Set title of main form
    Private Sub SetTitleTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetTitleTextToolStripMenuItem.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim TitleText1 As String

        TitleText1 = InputBox("Enter title text", "Title Text")
        Me.Text = TitleText1
    End Sub

    'Reset all items to original values
    Private Sub ResetAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllToolStripMenuItem.Click
        'Confirm with user that they want to reset all
        If MessageBox.Show("Are you sure you want to reset everything?", "Reset Confirmation", MessageBoxButtons.YesNo) = DialogResult.No Then
            'If dialog is NO, do nothing

        Else 'If dialog is YES, clear form
            ClearAllItems()
        End If
    End Sub

    'Toggle setting window to top-most in Windows
    '(Not working yet)
    Private Sub TopMostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopMostToolStripMenuItem.Click
        If TopMostToolStripMenuItem.CheckState = True Then
            Me.TopMost = True
        ElseIf TopMostToolStripMenuItem.CheckState = False Then
            Me.TopMost = False
        End If
    End Sub



    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 1 items below


    'Subtract 1 from counter
    Public Sub Counter1MinusButton_Click(sender As Object, e As EventArgs) Handles Counter1MinusButton.Click
        Counter1Count = Counter1Count - 1
        Counter1Label.Text = Counter1Count
    End Sub

    'Add 1 to counter
    Private Sub Counter1PlusButton_Click(sender As Object, e As EventArgs) Handles Counter1PlusButton.Click
        Counter1Count = Counter1Count + 1
        Counter1Label.Text = Counter1Count
    End Sub

    'Set name of counter
    Private Sub SetNameToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Counter1SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter1Text As String

        Counter1Text = InputBox("Enter counter text", "Counter Text")
        Counter1GroupBox.Text = Counter1Text
    End Sub

    'Get user input, set counter to the number they entered
    Private Sub SetNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Counter1SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter1Count = userInput
            Counter1Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    'Reset name of counter
    Private Sub ResetNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Counter1ResetNameToolStrip.Click
        Counter1GroupBox.Text = "Counter 1"
    End Sub

    'Reset counter back to 0
    Private Sub ResetCounterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Counter1ResetNumberToolStrip.Click
        Counter1Label.Text = "0"
        Counter1Count = 0
    End Sub




    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 2 items below

    Private Sub Counter2MinusButton_Click(sender As Object, e As EventArgs) Handles Counter2MinusButton.Click
        Counter2Count = Counter2Count - 1
        Counter2Label.Text = Counter2Count
    End Sub

    Private Sub Counter2PlusButton_Click(sender As Object, e As EventArgs) Handles Counter2PlusButton.Click
        Counter2Count = Counter2Count + 1
        Counter2Label.Text = Counter2Count
    End Sub

    Private Sub Counter2SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter2SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter2Text As String

        Counter2Text = InputBox("Enter counter text", "Counter Text")
        Counter2GroupBox.Text = Counter2Text
    End Sub

    Private Sub Counter2SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter2SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter2Count = userInput
            Counter2Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter2ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter2ResetNameToolStrip.Click
        Counter2GroupBox.Text = "Counter 2"
    End Sub

    Private Sub Counter2ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter2ResetNumberToolStrip.Click
        Counter2Label.Text = "0"
        Counter2Count = 0
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 3 items below

    Private Sub Counter3MinusButton_Click(sender As Object, e As EventArgs) Handles Counter3MinusButton.Click
        Counter3Count = Counter3Count - 1
        Counter3Label.Text = Counter3Count
    End Sub

    Private Sub Counter3PlusButton_Click(sender As Object, e As EventArgs) Handles Counter3PlusButton.Click
        Counter3Count = Counter3Count + 1
        Counter3Label.Text = Counter3Count
    End Sub

    Private Sub Counter3SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter3SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter3Text As String

        Counter3Text = InputBox("Enter counter text", "Counter Text")
        Counter3GroupBox.Text = Counter3Text
    End Sub

    Private Sub Counter3SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter3SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter3Count = userInput
            Counter3Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter3ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter3ResetNameToolStrip.Click
        Counter3GroupBox.Text = "Counter 3"
    End Sub

    Private Sub Counter3ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter3ResetNumberToolStrip.Click
        Counter3Label.Text = "0"
        Counter3Count = 0
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 4 items below

    Private Sub Counter4MinusButton_Click(sender As Object, e As EventArgs) Handles Counter4MinusButton.Click
        Counter4Count = Counter4Count - 1
        Counter4Label.Text = Counter4Count
    End Sub

    Private Sub Counter4PlusButton_Click(sender As Object, e As EventArgs) Handles Counter4PlusButton.Click
        Counter4Count = Counter4Count + 1
        Counter4Label.Text = Counter4Count
    End Sub

    Private Sub Counter4SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter4SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter4Text As String

        Counter4Text = InputBox("Enter counter text", "Counter Text")
        Counter4GroupBox.Text = Counter4Text
    End Sub

    Private Sub Counter4SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter4SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter4Count = userInput
            Counter4Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter4ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter4ResetNameToolStrip.Click
        Counter4GroupBox.Text = "Counter 4"
    End Sub

    Private Sub Counter4ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter4ResetNumberToolStrip.Click
        Counter4Label.Text = "0"
        Counter4Count = 0
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 5 items below

    Private Sub Counter5MinusButton_Click(sender As Object, e As EventArgs) Handles Counter5MinusButton.Click
        Counter5Count = Counter5Count - 1
        Counter5Label.Text = Counter5Count
    End Sub

    Private Sub Counter5PlusButton_Click(sender As Object, e As EventArgs) Handles Counter5PlusButton.Click
        Counter5Count = Counter5Count + 1
        Counter5Label.Text = Counter5Count
    End Sub

    Private Sub Counter5SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter5SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter5Text As String

        Counter5Text = InputBox("Enter counter text", "Counter Text")
        Counter5GroupBox.Text = Counter5Text
    End Sub

    Private Sub Counter5SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter4SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter5Count = userInput
            Counter5Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter5ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter5ResetNameToolStrip.Click
        Counter5GroupBox.Text = "Counter 5"
    End Sub

    Private Sub Counter5ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter5ResetNumberToolStrip.Click
        Counter5Label.Text = "0"
        Counter5Count = 0
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 6 items below

    Private Sub Counter6MinusButton_Click(sender As Object, e As EventArgs) Handles Counter6MinusButton.Click
        Counter6Count = Counter6Count - 1
        Counter6Label.Text = Counter6Count
    End Sub

    Private Sub Counter6PlusButton_Click(sender As Object, e As EventArgs) Handles Counter6PlusButton.Click
        Counter6Count = Counter6Count + 1
        Counter6Label.Text = Counter6Count
    End Sub

    Private Sub Counter6SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter6SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter6Text As String

        Counter6Text = InputBox("Enter counter text", "Counter Text")
        Counter6GroupBox.Text = Counter6Text
    End Sub

    Private Sub Counter6SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter6SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter6Count = userInput
            Counter6Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter6ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter6ResetNameToolStrip.Click
        Counter6GroupBox.Text = "Counter 6"
    End Sub

    Private Sub Counter6ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter6ResetNumberToolStrip.Click
        Counter6Label.Text = "0"
        Counter6Count = 0
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 7 items below

    Private Sub Counter7MinusButton_Click(sender As Object, e As EventArgs) Handles Counter7MinusButton.Click
        Counter7Count = Counter7Count - 1
        Counter7Label.Text = Counter7Count
    End Sub

    Private Sub Counter7PlusButton_Click(sender As Object, e As EventArgs) Handles Counter7PlusButton.Click
        Counter7Count = Counter7Count + 1
        Counter7Label.Text = Counter7Count
    End Sub

    Private Sub Counter7SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter7SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter7Text As String

        Counter7Text = InputBox("Enter counter text", "Counter Text")
        Counter7GroupBox.Text = Counter7Text
    End Sub

    Private Sub Counter7SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter7SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter7Count = userInput
            Counter7Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter7ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter7ResetNameToolStrip.Click
        Counter7GroupBox.Text = "Counter 7"
    End Sub

    Private Sub Counter7ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter7ResetNumberToolStrip.Click
        Counter7Label.Text = "0"
        Counter7Count = 0
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 8 items below

    Private Sub Counter8MinusButton_Click(sender As Object, e As EventArgs) Handles Counter8MinusButton.Click
        Counter8Count = Counter8Count - 1
        Counter8Label.Text = Counter8Count
    End Sub

    Private Sub Counter8PlusButton_Click(sender As Object, e As EventArgs) Handles Counter8PlusButton.Click
        Counter8Count = Counter8Count + 1
        Counter8Label.Text = Counter8Count
    End Sub

    Private Sub Counter8SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter8SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter8Text As String

        Counter8Text = InputBox("Enter counter text", "Counter Text")
        Counter8GroupBox.Text = Counter8Text
    End Sub

    Private Sub Counter8SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter8SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter8Count = userInput
            Counter8Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter8ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter8ResetNameToolStrip.Click
        Counter8GroupBox.Text = "Counter 8"
    End Sub

    Private Sub Counter8ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter8ResetNumberToolStrip.Click
        Counter8Label.Text = "0"
        Counter8Count = 0
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Counter 9 items below

    Private Sub Counter9MinusButton_Click(sender As Object, e As EventArgs) Handles Counter9MinusButton.Click
        Counter9Count = Counter9Count - 1
        Counter9Label.Text = Counter9Count
    End Sub

    Private Sub Counter9PlusButton_Click(sender As Object, e As EventArgs) Handles Counter9PlusButton.Click
        Counter9Count = Counter9Count + 1
        Counter9Label.Text = Counter9Count
    End Sub

    Private Sub Counter9SetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter9SetNameToolStrip.Click
        'When clicked, show popup asking user what to set the title text in the main form
        Dim Counter9Text As String

        Counter9Text = InputBox("Enter counter text", "Counter Text")
        Counter9GroupBox.Text = Counter9Text
    End Sub

    Private Sub Counter9SetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter9SetNumberToolStrip.Click
        Dim CheckInput As Integer
        Dim userInput As String = InputBox("Number to set counter to", "Counter Number", "0")
        Dim validInput As Boolean = Integer.TryParse(userInput, CheckInput)

        'If statement to validate the user is entering only numbers
        If validInput = True Then
            Counter9Count = userInput
            Counter9Label.Text = userInput.ToString()
        ElseIf validInput = False Then
            MessageBox.Show("Non-integer value detected. Enter only numbers into the box!", "Can't you read?")
        End If
    End Sub

    Private Sub Counter9ResetNameToolStrip_Click(sender As Object, e As EventArgs) Handles Counter9ResetNameToolStrip.Click
        Counter9GroupBox.Text = "Counter 9"
    End Sub

    Private Sub Counter9ResetNumberToolStrip_Click(sender As Object, e As EventArgs) Handles Counter9ResetNumberToolStrip.Click
        Counter9Label.Text = "0"
        Counter9Count = 0
    End Sub

End Class 'End program
