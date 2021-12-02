using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace IrisCalculator
{
    public class Handler
    {
        private string[] data;

        private IDataReader _fileHandler;
        private IIrisDrawer _drawer;

        private List<MathVector> setosaIris = new List<MathVector>();
        private List<MathVector> versicolorIris = new List<MathVector>();
        private List<MathVector> virginicaIris = new List<MathVector>();

        private MathVector setosaAverageVector;
        private MathVector versicolorAverageVector;
        private MathVector virginicaAverageVector;

        public Handler(IDataReader reader, IIrisDrawer drawer)
        {
            _fileHandler = reader;
            _drawer = drawer;
        }

        public void ReadData()
        {
            try
            {
                data = _fileHandler.ReadData();
            }
            catch (Exception e)
            {
                
            }
        }


        private MathVector ParseVector(string[] arr)
        {
            MathVector vector = new MathVector(new double[]
            {
                    double.Parse(arr[0].Replace('.', ',')),
                    double.Parse(arr[1].Replace('.', ',')),
                    double.Parse(arr[2].Replace('.', ',')),
                    double.Parse(arr[3].Replace('.', ','))
            });

            return vector;
        }

        public void ProcessData()
        {
            if(data == null)
            {  
                return;
            }

            setosaIris.Clear();
            versicolorIris.Clear();
            virginicaIris.Clear();

            for (int i = 1; i < data.Length; i++)
            {
                string[] splited = data[i].Split(',');

                string irisType = splited[splited.Length - 1];

                MathVector vector = ParseVector(splited);

                switch (irisType)
                {
                    case "setosa":
                        setosaIris.Add(vector);
                        break;
                    case "versicolor":
                        versicolorIris.Add(vector);
                        break;
                    case "virginica":
                        virginicaIris.Add(vector);
                        break;
                }
            }

            CalcAverageVectors();
        }

        public void CalcAverageVectors()
        {
            setosaAverageVector = CalcAverageVector(setosaIris);
            versicolorAverageVector = CalcAverageVector(versicolorIris);
            virginicaAverageVector = CalcAverageVector(virginicaIris);
        }

        private MathVector CalcAverageVector(List<MathVector> list)
        {
            var averageVector = new MathVector( new double[] { 0, 0, 0, 0 });

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < averageVector.Dimensions; j++)
                {
                    averageVector[j] += list[i][j];
                }
            }

            for (int j = 0; j < averageVector.Dimensions; j++)
            {
                averageVector[j] /= list.Count;
            }

            return averageVector;
        }

        public void DrawInfo ()
        {
            for (int i = 0; i < 4; i++)
            {
                _drawer.DrawGraphics(
                    new double[]
                    {
                        setosaAverageVector[i],
                        versicolorAverageVector[i],
                        virginicaAverageVector[i],
                    },
                    (IrisMetrics)i,
                    new string[] {"Setosa", "Versicolor", "Virginica"}
                );
            }

            _drawer.DrawPieGraphic(new double[]
                {
                    setosaAverageVector.CalcDistance(versicolorAverageVector),
                    setosaAverageVector.CalcDistance(virginicaAverageVector),
                    versicolorAverageVector.CalcDistance(virginicaAverageVector),
                },
                new string[] { "set-ver", "set-vir", "ver-vir" }
            );
           
        }
    }
}
