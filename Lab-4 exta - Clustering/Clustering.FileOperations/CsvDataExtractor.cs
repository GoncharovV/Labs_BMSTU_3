using LinearAlgebra;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clustering.FileOperations
{
    public class CsvDataExtractor : IDataExtractor
    {
        private string _filePath;

        public CsvDataExtractor(string path)
        {
            _filePath = path;
        }

        public List<Point> GetVectors()
        {
            string[] data = File.ReadAllLines(_filePath);

            var points = new List<Point>();

            foreach (var line in data)
            {
                string[] splited = line.Trim().Split(new string[] { "   " }, StringSplitOptions.None);
                points.Add(new Point(new MathVector(new double[]
                {
                    double.Parse(splited[0]),
                    double.Parse(splited[1]),
                }), 0));
            }

            return points;
        }
    }
}
