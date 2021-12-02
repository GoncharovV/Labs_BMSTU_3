using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clustering;
using System.Windows.Forms.DataVisualization.Charting;
using LinearAlgebra;
using System.Drawing;

namespace ClustersPresentation
{
    public class WinFormsClusteringVisualizer : IClusteringVisualizer
    {
        private readonly Chart view_chart;
        public WinFormsClusteringVisualizer(Chart chart)
        {
            this.view_chart = chart;
        }

        public void VisualizeData(IEnumerable<Clustering.Point> points)
        {
            view_chart.Series.Clear();
            Series series = new Series("Points");
            series.ChartType = SeriesChartType.Point;

            foreach (var point in points)
            {
                series.Points.AddXY(point.Position[0], point.Position[1]);
                series.Points.Last().Color = DetermineColorByClusterId(point.ClusterID);
            }

            view_chart.Series.Add(series);
        }

        public void VisualizeClusters(IEnumerable<Cluster> clusters)
        {
            Series series = new Series("Clusters");
            series.ChartType = SeriesChartType.Point;
            series.BorderWidth = 8;
            series.Color = Color.Red;

            foreach (var cluster in clusters)
            {
                series.Points.AddXY(cluster.ClusterCenter[0], cluster.ClusterCenter[1]);
            }

            view_chart.Series.Add(series);
        }

        private Color DetermineColorByClusterId(int id)
        {
            switch (id)
            {
                case 0:
                    return Color.CornflowerBlue;
                case 1:
                    return Color.DarkRed;
                case 2:
                    return Color.Aqua;
                case 3:
                    return Color.DarkGray;
                case 4:
                    return Color.DarkOrange;
                case 5:
                    return Color.DeepPink;
                case 6:
                    return Color.DarkMagenta;
                case 7:
                    return Color.Brown;
                case 8:
                    return Color.Crimson;
                case 9:
                    return Color.Firebrick;
                case 10:
                    return Color.Gold; 
                case 11:
                    return Color.CornflowerBlue;
                case 12:
                    return Color.DodgerBlue;
                case 13:
                    return Color.BlueViolet;
                case 14:
                    return Color.Cyan;
                default:
                    return Color.Blue;
            }
        }
    }
}
