using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Clustering
{
    public interface IClusterer
    {
        void InitClusters();

        IEnumerable<Cluster> Clusters { get; }
        IEnumerable<Point> Points { get; }

        Cluster DetermineClusterMembership(IMathVector vector);
    }
}
