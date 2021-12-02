using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Clustering
{
    public class Point
    {
        public Point(IMathVector position, int clusterID)
        {
            Position = position;
            ClusterID = clusterID;
        }

        public IMathVector Position { get; }

        public int ClusterID { get; set; }

    }
}
