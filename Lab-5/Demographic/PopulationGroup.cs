using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class PopulationGroup
    {
        public string GropName { get; }

        public int GroupSize { get; }

        public PopulationGroup(string gropName, int groupSize)
        {
            GropName = gropName;
            GroupSize = groupSize;
        }
    }
}
