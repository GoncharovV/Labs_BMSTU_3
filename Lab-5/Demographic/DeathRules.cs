using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class DeathRules
    {
        private readonly List<TimeInterval> timeIntervals;

        public DeathRules(List<TimeInterval> timeIntervals)
        {
            this.timeIntervals = timeIntervals;
        }
        public double GetDeathProbability(int age, Genders gender)
        {
            TimeInterval founded = timeIntervals.FirstOrDefault(interval => interval.IsInInterval(age));

            if (founded != null)
            {
                return founded.GetDeathProbability(gender);
            }
            else
            {
                return timeIntervals.Last().GetDeathProbability(gender);
            }
        }
    }
}
