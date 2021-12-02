using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrisCalculator;

namespace Lab_4
{
    class FileHandler: IDataReader
    {
        private string path;

        public FileHandler(string input)
        {
            path = input;
        }
        public string[] ReadData()
        {
            if (!File.Exists(path))
            {
                throw new Exception();
            }

            return File.ReadAllLines(path);
        }
    }
}
