using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // Create a chart control.
            ChartControl chartControl1 = new ChartControl();

            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);

            // Create a bar series and add points to it.
            Series series1 = new Series("Series 1", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("A", new double[] { 26.25 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 1.52 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 22.21 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 15.35 }));
            series1.Points.Add(new SeriesPoint("E", new double[] { 4.15 }));

            // Add the series to the chart.
            chartControl1.Series.Add(series1);

            // Cast the chart's diagram to the XYDiagram type, to access its axes.
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            // Enable the diagram's scrolling.
            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisYScrolling = true;

            // Define the whole range for the X-axis. 
            diagram.AxisX.WholeRange.Auto = false;
            diagram.AxisX.WholeRange.SetMinMaxValues("A", "D");

            // Disable the side margins 
            // (this has an effect only for certain view types).
            diagram.AxisX.VisualRange.AutoSideMargins = false;

            // Limit the visible range for the X-axis.
            diagram.AxisX.VisualRange.Auto = false;
            diagram.AxisX.VisualRange.SetMinMaxValues("B", "C");

            // Define the whole range for the Y-axis. 
            diagram.AxisY.WholeRange.Auto = false;
            diagram.AxisY.WholeRange.SetMinMaxValues(1, 26);
        }
    }
}
