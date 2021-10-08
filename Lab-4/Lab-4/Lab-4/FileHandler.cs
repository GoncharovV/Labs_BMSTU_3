using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class FileHandler
    {
        public string[] ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception();
            }

            return File.ReadAllLines(path);
        }
    }
}
