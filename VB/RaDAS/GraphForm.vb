Public Class GraphForm

    Public Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        graph()
    End Sub

    Private Sub Form2_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        graph()
    End Sub

    Private Sub graph()
        Dim dataTable As New DataTable

        With dataTable
            .Columns.Add("t", GetType(System.Double))
            .Columns.Add("v", GetType(System.Double))
        End With

        For i = 1 To numberOfIntervals
            dataTable.Rows.Add({secs_sum(i), velocities(i)})
        Next

        Chart1.Series.Clear()
        Chart1.DataSource = dataTable

        Dim secs_serie As New DataVisualization.Charting.Series()
        Dim velocities_serie As New DataVisualization.Charting.Series()
        Dim lenghts_serie As New DataVisualization.Charting.Series()

        With velocities_serie
            .ChartType = DataVisualization.Charting.SeriesChartType.FastPoint
            .Color = Color.Green
            .BorderWidth = 2
            .MarkerSize = 3
            .MarkerBorderColor = Color.Red
            .MarkerBorderWidth = 2
            .MarkerStyle = DataVisualization.Charting.MarkerStyle.Square

            .XValueMember = dataTable.Columns("t").ToString
            .YValueMembers = dataTable.Columns("v").ToString

        End With

        Chart1.Series.Add(velocities_serie)
        Chart1.Visible = True

    End Sub

End Class