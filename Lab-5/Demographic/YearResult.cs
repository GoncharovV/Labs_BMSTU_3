using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class YearResult
    {
        public int Year { get; }

        public double Value { get; }

        public YearResult(int year, double value)
        {
            Year = year;
            Value = value;
        }

    }
}
