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
using IrisCalculator;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private Handler _handler;
        public Form1()
        {
            InitializeComponent();

            sepal_lenght.Titles.Add("Sepal Lenght");
            sepal_width.Titles.Add("Sepal Width");
            petal_lenght.Titles.Add("Petal Lenght");
            petal_width.Titles.Add("Petal Width");


            ClearCharts();
        }

        private void DisplayError(object sender, string value)
        {
            MessageBox.Show(value, "Ошибка");
        }

        private void ClearCharts()
        {
            sepal_lenght.Series.Clear();
            sepal_width.Series.Clear();
            petal_lenght.Series.Clear();
            petal_width.Series.Clear();
            chart_pie.Series.Clear();
        }

        private void file_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;

            IIrisDrawer drawer = new GraphicDrawer(sepal_lenght, sepal_width, petal_lenght, petal_width, chart_pie);

            _handler = new Handler(new FileHandler(openFileDialog1.FileName), drawer);

            _handler.ReadData();

            _handler.ProcessData();

            _handler.DrawInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {

        }

        private void sepal_width_Click(object sender, EventArgs e)
        {

        }
    }
}
