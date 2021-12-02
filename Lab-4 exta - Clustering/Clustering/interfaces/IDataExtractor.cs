using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Clustering
{
    public interface IDataExtractor
    {
        List<Point> GetVectors();
    }
}
