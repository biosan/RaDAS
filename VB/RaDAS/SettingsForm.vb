Public Class SettingsForm

    Dim flag As Boolean = False

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Shown

        NumericUpDown1.Value = decimalDigits
        NumericUpDown2.Value = railLenght

    End Sub

    Private Sub decimalDigitsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.Validated, NumericUpDown1.MouseCaptureChanged, NumericUpDown1.Leave, NumericUpDown1.Enter, NumericUpDown1.DoubleClick, NumericUpDown1.Click

        decimalDigits = NumericUpDown1.Value
        DataForm.writeData()

    End Sub

    Private Sub railLenghtChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.Validated, NumericUpDown2.MouseCaptureChanged, NumericUpDown2.Leave, NumericUpDown2.Enter, NumericUpDown2.DoubleClick, NumericUpDown2.Click

        railLenght = NumericUpDown2.Value
        For i = 1 To numberOfIntervals
            DataForm.lenghtTexts(i).Maximum = railLenght
        Next
        DataForm.updateLenghts()

    End Sub

End Class