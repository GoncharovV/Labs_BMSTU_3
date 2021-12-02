using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Clustering
{
    public class Cluster
    {
        public Cluster(IMathVector clusterCenter, int id)
        {
            Id = id;
            ClusterCenter = clusterCenter;
        }

        public int Id { get; }

        public IMathVector ClusterCenter { get; private set; }

        public void MoveClusterCenter (IMathVector vector)
        {
            for (int i = 0; i < ClusterCenter.Dimensions; i++)
            {
                ClusterCenter[i] = (ClusterCenter[i] + vector[i]) / 2;
            }
        }
    }
}
