using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrisCalculator;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using LinearAlgebra;

namespace Lab_4
{
    class GraphicDrawer: IIrisDrawer
    {
        Chart sepalLengthChart;
        Chart sepalWidthChart;
        Chart petalLengthChart;
        Chart petalWidthChart;
        Chart pieChart;


        public GraphicDrawer(Chart sepalLength, Chart sepalWidth, Chart petalLength, Chart petalWidth, Chart pieChart)
        {
            this.sepalLengthChart = sepalLength;
            this.sepalWidthChart = sepalWidth;
            this.petalLengthChart = petalLength;
            this.petalWidthChart = petalWidth;

            this.pieChart = pieChart;
        }

        public void DrawGraphics(double[] list, IrisMetrics metric, string[] captions)
        {
            switch (metric)
            {
                case IrisMetrics.PETAL_LENGTH:
                    ProcessChart(petalLengthChart, list, captions);
                    break;

                case IrisMetrics.PETAL_WIDTH:
                    ProcessChart(petalWidthChart, list, captions);
                    break;

                case IrisMetrics.SEPAL_LENGHT:
                    ProcessChart(sepalLengthChart, list, captions);
                    break;

                case IrisMetrics.SEPAL_WIDTH:
                    ProcessChart(sepalWidthChart, list, captions);
                    break;
            }
        }

        public void DrawPieGraphic(double[] list, string[] captions)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY(captions[0], list[0]);
            series.Points.AddXY(captions[1], list[1]);
            series.Points.AddXY(captions[2], list[2]);

            pieChart.Series.Clear();
            pieChart.Series.Add(series);
        }

        private void ProcessChart(Chart chart, double[] list, string[] captions)
        {
            chart.Series.Clear();

            for (int i = 0; i < list.Length; i++)
            {
                chart.Series.Add(new Series(captions[i]));
                chart.Series.Last().Points.Add(list[i]);
            }

        }
    }
}
