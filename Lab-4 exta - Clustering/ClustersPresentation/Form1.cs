using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Clustering;
using Clustering.FileOperations;

namespace ClustersPresentation
{
    public partial class Form1 : Form
    {
        private const int CLUSTER_COUNT = 15;
        private const string FILE_PATH = @"G:\Downloads\s1.txt";

        IClusterer clusterer = new KmeansClusterer(new CsvDataExtractor(FILE_PATH), CLUSTER_COUNT);
        IClusteringVisualizer visualizer;
        public Form1()
        {
            InitializeComponent();
            view_chart.Series.Clear();
            visualizer = new WinFormsClusteringVisualizer(view_chart);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {

            ((KmeansClusterer)clusterer).Start();

            visualizer.VisualizeData(clusterer.Points);

            visualizer.VisualizeClusters(clusterer.Clusters);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visualizer.VisualizeData(clusterer.Points);

            clusterer.InitClusters();

            visualizer.VisualizeClusters(clusterer.Clusters);
        }
    }
}
