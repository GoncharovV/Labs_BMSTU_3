using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public interface IEngine
    {
        int StartYear { get; }
        int EndYear { get; }
        int StartPopulation { get; }

        void StartEmulation();

        List<YearResult> GetTotalPopulationStats();
        List<YearResult> GetMalePopulationStats();
        List<YearResult> GetFemalePopulationStats();

        List<PopulationGroup> GetMaleComposition();
        List<PopulationGroup> GetFemaleComposition();

    }
}
