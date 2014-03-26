Public Class SettingsForm

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        NumericUpDown1.Value = decimalDigits
        NumericUpDown2.Value = railLenght

    End Sub

    Private Sub decimalDigitsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

        decimalDigits = NumericUpDown1.Value
        DataForm.writeData()

    End Sub
    Private Sub railLenghtChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged

        railLenght = NumericUpDown2.Value
        For i = 1 To numberOfIntervals
            DataForm.lenghtTexts(i).Maximum = railLenght
        Next
        DataForm.updateLenghts()

    End Sub

End Class