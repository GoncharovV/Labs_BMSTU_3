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

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private readonly Handler _handler;
        public Form1()
        {
            InitializeComponent();

            _handler = new Handler();

            _handler.ErrorEmitter += DisplayError;

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

            _handler.ReadData(openFileDialog1.FileName);

            _handler.SetSeriesToChart(sepal_lenght, Handler.SeriesTypes.SEPAL_LENGHT);
            _handler.SetSeriesToChart(sepal_width, Handler.SeriesTypes.SEPAL_WIDTH);
            _handler.SetSeriesToChart(petal_lenght, Handler.SeriesTypes.PETAL_LENGTH);
            _handler.SetSeriesToChart(petal_width, Handler.SeriesTypes.PETAL_WIDTH);

            _handler.SetSeriesToPieChart(chart_pie);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
