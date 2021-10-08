using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
namespace Lab_4
{
    class Handler
    {
        private string[] data;
        private readonly FileHandler _fileHandler;

        private readonly Dictionary<string, List<MathVector>> Irises; 
        private readonly Dictionary<string, MathVector> AvgIrisVectors;

        public event EventHandler<string> ErrorEmitter;

        public enum SeriesTypes
        {
            SEPAL_LENGHT,
            SEPAL_WIDTH,
            PETAL_LENGTH,
            PETAL_WIDTH
        }

        public Handler()
        {
            _fileHandler = new FileHandler();

            Irises = new Dictionary<string, List<MathVector>>();
            AvgIrisVectors = new Dictionary<string, MathVector>();

            /*            Irises.Add("setosa", new List<MathVector>());
                        Irises.Add("versicolor", new List<MathVector>());
                        Irises.Add("virginica", new List<MathVector>());*/

        }

        public void ReadData(string path)
        {
            try
            {
                data = _fileHandler.ReadFile(path);
            }
            catch (Exception e)
            {
                ErrorEmitter?.Invoke(this, e.Message);
            }
        }

        public void ProcessData()
        {
            if(data == null)
            {
                ErrorEmitter?.Invoke(this, "Данные не загружены");
                return;
            }

            Irises.Clear();

            for (int i = 1; i < data.Length; i++)
            {
                string[] splited = data[i].Split(',').Select(value => value.Replace('.', ',')).ToArray();

                MathVector vector = new MathVector(new double[]
                {
                    double.Parse(splited[0]),
                    double.Parse(splited[1]),
                    double.Parse(splited[2]),
                    double.Parse(splited[3])
                });

                string irisType = splited[splited.Length - 1];

                if (Irises.Keys.Contains(irisType))
                {
                    Irises[irisType].Add(vector);
                }
                else
                {
                    Irises.Add(irisType, new List<MathVector> { vector });
                }
            }
        }

        public void CalcAverageVectors()
        {
            AvgIrisVectors.Clear();

            foreach(string key in Irises.Keys)
            {
                AvgIrisVectors.Add(
                    key,
                    new MathVector(CalcAvgVector(Irises[key]))
                );
            }
        }

        private double[] CalcAvgVector(List<MathVector> list)
        {
            var averageVector = new double[] { 0, 0, 0, 0 };

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < averageVector.Length; j++)
                {
                    averageVector[j] += list[i][j];
                }
            }

            for (int j = 0; j < averageVector.Length; j++)
            {
                averageVector[j] /= list.Count;
            }

            return averageVector;
        }

        public void SetSeriesToChart(Chart chart, SeriesTypes type)
        {
            try
            {
                ProcessData();
                CalcAverageVectors();
            } 
            catch (Exception _)
            {
                ErrorEmitter?.Invoke(this, "Ошибка входных данных");
                return;
            }

            chart.Series.Clear();

            foreach (string key in AvgIrisVectors.Keys)
            {
                chart.Series.Add(new Series(key));
                chart.Series.Last().Points.Add(AvgIrisVectors[key][(int)type]);
            }
        }

        public void SetSeriesToPieChart(Chart chart)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY("set-ver", AvgIrisVectors["setosa"].CalcDistance(AvgIrisVectors["versicolor"]));
            series.Points.AddXY("set-vir", AvgIrisVectors["setosa"].CalcDistance(AvgIrisVectors["virginica"]));
            series.Points.AddXY("ver-vir", AvgIrisVectors["versicolor"].CalcDistance(AvgIrisVectors["virginica"]));

            chart.Series.Clear();
            chart.Series.Add(series);
        }
    }
}
