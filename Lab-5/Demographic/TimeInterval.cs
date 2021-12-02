using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class TimeInterval
    {
        private int StartYear { get; }

        private int EndYear { get; }

        public double DeathProbabilityMale { get; }
        public double DeathProbabilityFemale { get; }

        public TimeInterval(int startYear, int endYear, double deathProbabilityMale, double deathProbabilityFemale)
        {
            StartYear = startYear;
            EndYear = endYear;
            DeathProbabilityMale = deathProbabilityMale;
            DeathProbabilityFemale = deathProbabilityFemale;
        }

        public bool IsInInterval(int age)
        {
            return age >= StartYear && age <= EndYear;
        }

        public double GetDeathProbability(Genders gender)
        {
            if (gender == Genders.Male)
            {
                return DeathProbabilityMale;
            }
            else
            {
                return DeathProbabilityFemale;
            }
        }
    }
}
