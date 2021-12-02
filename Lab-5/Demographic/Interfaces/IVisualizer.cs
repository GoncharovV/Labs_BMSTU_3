using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public interface IVisualizer
    {
        void VisualizeTotalPopulation(List<YearResult> data);

        void VisualizeMalePopulation(List<YearResult> data);

        void VisualizeFemalePopulation(List<YearResult> data);

        void VisualizeMaleComposition(List<PopulationGroup> data);

        void VisualizeFemaleComposition(List<PopulationGroup> data);
    }
}
