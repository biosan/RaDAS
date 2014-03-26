Public Class InitForm

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox_Ports.Items.Clear()
        ComboBox_Ports.Items.AddRange(IO.Ports.SerialPort.GetPortNames)
    End Sub

    Private Sub ComboBox_Ports_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Ports.SelectedIndexChanged
        If ComboBox_Ports.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        COMPort = ComboBox_Ports.Text
        Dim yes As Integer = MsgBox("Connect to " + COMPort + " ?", MsgBoxStyle.YesNo, "Connection")
        If yes = 6 Then
            With DataForm.serialPort
                .PortName = COMPort
                If .IsOpen Then
                    .Close()
                End If
                .Open()
            End With

            DataForm.Visible = True
            Me.Visible = False
        End If
    End Sub

    Private Sub ComboBox_Ports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Ports.Click
        ComboBox_Ports.Items.Clear()
        ComboBox_Ports.Items.AddRange(IO.Ports.SerialPort.GetPortNames)
    End Sub
End Class