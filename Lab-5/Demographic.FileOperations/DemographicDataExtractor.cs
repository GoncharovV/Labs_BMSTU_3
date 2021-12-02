using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demographic.FileOperations
{
    public class DemographicDataExtractor : IDataExtractor
    {
        private readonly string _initialAgePath;
        private readonly string _deathRulesPath;
        public DemographicDataExtractor(string initialAgePath, string deathRulePath)
        {
            _initialAgePath = initialAgePath; 
            _deathRulesPath = deathRulePath;
        }

        public DeathRules GetDeathRules()
        {
            string[] data = File.ReadAllLines(_deathRulesPath);

            var timeIntervals = new List<TimeInterval>();

            for (int i = 1; i < data.Length; i++)
            {
                string[] splited = data[i].Split(',');

                timeIntervals.Add(new TimeInterval(
                    int.Parse(splited[0]),
                    int.Parse(splited[1]),
                    double.Parse(splited[2].Replace('.', ',')),
                    double.Parse(splited[3].Replace('.', ',')))
                );
            }

            return new DeathRules(timeIntervals);
        }

        public (int age, double ratio)[] GetInitialAges()
        {
            string[] data = File.ReadAllLines(_initialAgePath);

            var ouput = new (int age, double ratio)[data.Length];

            for (int i = 1; i < data.Length; i++)
            {
                string[] splited = data[i].Split(',');
                ouput[i] = (int.Parse(splited[0]), double.Parse(splited[1].Replace('.', ',')));
            }

            return ouput;
        }
    }
}
