Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            ' Create a chart control.
            Dim chartControl1 As New ChartControl()

            ' Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill
            Me.Controls.Add(chartControl1)

            ' Create a bar series and add points to it.
            Dim series1 As New Series("Series 1", ViewType.Bar)
            series1.Points.Add(New SeriesPoint("A", New Double() { 26.25 }))
            series1.Points.Add(New SeriesPoint("B", New Double() { 1.52 }))
            series1.Points.Add(New SeriesPoint("C", New Double() { 22.21 }))
            series1.Points.Add(New SeriesPoint("D", New Double() { 15.35 }))
            series1.Points.Add(New SeriesPoint("E", New Double() { 4.15 }))

            ' Add the series to the chart.
            chartControl1.Series.Add(series1)

            ' Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = CType(chartControl1.Diagram, XYDiagram)

            ' Enable the diagram's scrolling.
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisYScrolling = True

            ' Define the whole range for the X-axis. 
            diagram.AxisX.WholeRange.Auto = False
            diagram.AxisX.WholeRange.SetMinMaxValues("A", "D")

            ' Disable the side margins 
            ' (this has an effect only for certain view types).
            diagram.AxisX.VisualRange.AutoSideMargins = False

            ' Limit the visible range for the X-axis.
            diagram.AxisX.VisualRange.Auto = False
            diagram.AxisX.VisualRange.SetMinMaxValues("B", "C")

            ' Define the whole range for the Y-axis. 
            diagram.AxisY.WholeRange.Auto = False
            diagram.AxisY.WholeRange.SetMinMaxValues(1, 26)
        End Sub
    End Class
End Namespace
