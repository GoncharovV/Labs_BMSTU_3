using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Clustering
{
    public class KmeansClusterer : IClusterer
    {
        public IEnumerable<Cluster> Clusters { get => clusters; }
        public IEnumerable<Point> Points { get => points; }

        private List<Point> points;

        private List<Cluster> clusters = new List<Cluster>();

        private const int MAX_ITERATION_COUNT = 200;

        public int ClusterCount { get; }

        public KmeansClusterer(IDataExtractor extractor, int clusterCount )
        {
            ClusterCount = clusterCount;
            points = extractor.GetVectors();
        }

        public void Start ()
        {
            int[] ids = new int[points.Count];
            int[] ids2 = new int[points.Count];

            for (int i = 0; i < MAX_ITERATION_COUNT; i++)
            {
                if (i % 100 == 0) System.Diagnostics.Debug.WriteLine("Iteration: " + i);

                foreach (var point in points)
                {
                    int inx = 0;
                    double min = point.Position.CalcDistance(clusters[0].ClusterCenter);

                    for (int j = 0; j < ClusterCount; j++)
                    {
                        double distance = point.Position.CalcDistance(clusters[j].ClusterCenter);

                        if (distance < min)
                        {
                            min = distance;
                            inx = j;
                        }
                    }

                    clusters[inx].MoveClusterCenter(point.Position);
                }

                int iter = 0;
                foreach (var point in points)
                {
                    int inx = 0;
                    double min = point.Position.CalcDistance(clusters[0].ClusterCenter);

                    for (int j = 0; j < ClusterCount; j++)
                    {
                        double distance = point.Position.CalcDistance(clusters[j].ClusterCenter);

                        if (distance < min)
                        {
                            min = distance;
                            inx = j;
                        }
                    }

                    point.ClusterID = clusters[inx].Id;
                    ids[iter] = clusters[inx].Id;

                    iter++;
                }

                if (Enumerable.SequenceEqual(ids, ids2))
                {
                    System.Diagnostics.Debug.WriteLine("Equal " + i);
                    break;
                }

                ids.CopyTo(ids2, 0);
            }
        }

        public Cluster DetermineClusterMembership(IMathVector vector)
        {


            throw new NotImplementedException();
        }

        public void InitClusters()
        {
            Random rnd = new Random();

            int step = 200_000;
            int count = 0;

            for (int i = step; i < step * 4 + 1; i += step)
            {
                for (int j = step; j < step * 4 + 1; j += step)
                {
                    clusters.Add(new Cluster(
                    new MathVector(new double[] {
                                    i, j
                    })
                    , count));
                    count++;
                    if (count >= 15)
                    {
                        return;
                    }
                }
            }

/*            for (int i = 0; i < ClusterCount; i++)
            {
                clusters.Add(new Cluster(
                   new MathVector(new double[] {
                        rnd.Next(200_000, 1_000_000),
                        rnd.Next(200_000, 1_000_000),
                   })
                   , i));
            }*/
        }
    }
}
