Imports System.IO.Ports

Public Class DataForm

    Dim rawData As String                       ' Store the string red from the last line of serial port input buffer
    Dim tempData As String()                    ' Temp string array that store strings splitted from rawData input string
    ' Common controls arrays
    Public timeLabels(numberOfIntervals) As Label           '
    Public velocityLabels(numberOfIntervals) As Label       '
    Public lenghtTexts(numberOfIntervals) As NumericUpDown  '

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Setup_lenghtTexts()
        Setup_timeLabels()
        Setup_velocityLabels()
        writeData()
    End Sub

    Private Sub read()
        serialPort.DiscardInBuffer()
        tempData = Split(rawData, "-")
        For i = 1 To numberOfIntervals
            timeCounts(i) = Val(tempData(i))
            If timeCounts(i) > 0 Then
                secs(i) = timeCounts(i) / 1536
            End If
        Next
        writeData()
        updateData()
    End Sub

    Public Sub updateData()
        For i = 1 To numberOfIntervals
            If secs(i) <> 0 Then
                velocities(i) = lenghts(i) / secs(i)
            End If
        Next
    End Sub

    Public Sub writeData()
        Dim format As String = "F" + CStr(decimalDigits)
        For i = 1 To numberOfIntervals
            timeLabels(i).Text = secs(i).ToString(format)
            velocityLabels(i).Text = velocities(i).ToString(format)
        Next
    End Sub

    Private Sub updateCountsValue(ByVal input As String, ByVal data() As Integer)
        Dim tempData As String()                ' Temp string array that store strings splitted from rawData input string
        If input <> "" Then
            tempData = Split(input, "-")
            For i = 1 To numberOfIntervals
                data(i) = CDbl(tempData(i))
            Next
        End If
    End Sub

    Public Sub updateLenghts()
        For i = 1 To numberOfIntervals
            lenghts(i) = CDbl(lenghtTexts(i).Value)
        Next
    End Sub

    Private Sub Setup_timeLabels()
        timeLabels(1) = timeLabel1
        timeLabels(2) = timeLabel2
        timeLabels(3) = timeLabel3
        timeLabels(4) = timeLabel4
        timeLabels(5) = timeLabel5
    End Sub

    Private Sub Setup_velocityLabels()
        velocityLabels(1) = velocityLabel1
        velocityLabels(2) = velocityLabel2
        velocityLabels(3) = velocityLabel3
        velocityLabels(4) = velocityLabel4
        velocityLabels(5) = velocityLabel5
    End Sub

    Private Sub Setup_lenghtTexts()
        lenghtTexts(1) = lenghtText1
        lenghtTexts(2) = lenghtText2
        lenghtTexts(3) = lenghtText3
        lenghtTexts(4) = lenghtText4
        lenghtTexts(5) = lenghtText5
    End Sub

    Private Sub graphButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GraphForm.Visible = True

    End Sub

    Private Sub serialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        rawData = serialPort.ReadLine()
        Me.Invoke(New EventHandler(AddressOf read))

    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        GraphForm.Visible = True

    End Sub

    Private Sub lenghtText1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lenghtText5.ValueChanged, lenghtText4.ValueChanged, lenghtText3.ValueChanged, lenghtText2.ValueChanged, lenghtText1.ValueChanged
        updateLenghts()
        updateData()
        AllowGraph()
        writeData()

    End Sub

    Private Sub AllowGraph()
        For i = 1 To numberOfIntervals
            If velocities(i) = 0 Then
                ShowToolStripMenuItem.Enabled = False
                Exit For
            Else
                ShowToolStripMenuItem.Enabled = True
            End If
        Next
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        FileName = SaveFileDialog1.FileName
        With Date.Today
            FileName = FileName + "_" + CStr(.Day) + "-" + CStr(.Month) + "-" + CStr(.Year)
        End With
        FilePath = FileName + ".txt"
        CreateFile()

    End Sub

    Private Sub CreateFile()
        Dim File = New IO.StreamWriter(FilePath, True)
        File.WriteLine(Date.Now)
        For i = 1 To numberOfIntervals
            OutputFile(i) = secs(i).ToString("F3") + ";" + lenghts(i).ToString("F3") + ";" + velocities(i).ToString("F3")
            File.WriteLine(OutputFile(i))
        Next
        File.WriteLine("")
        File.Flush()
        File.Close()

    End Sub
    Private Sub ToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToFileToolStripMenuItem.Click
        FolderBrowserDialog1.ShowDialog()
        FileName = FolderBrowserDialog1.SelectedPath + "\rail_data"
        With Date.Now
            FileName = FileName + "_" + CStr(.Day) + "-" + CStr(.Month) + "-" + CStr(.Year)
        End With
        FilePath = FileName + ".txt"
        Try
            CreateFile()
        Catch ex As Exception
            MsgBox("Exeption! File not saved")
        End Try

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        SettingsForm.Show()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        CreditsForm.Show()
    End Sub
End Class