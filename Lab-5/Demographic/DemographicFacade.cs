using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class DemographicFacade
    {
        private readonly IEngine _engine;

        private readonly IVisualizer _visualizer;
        public DemographicFacade(IEngine engine, IVisualizer visualizer)
        {
            _engine = engine;
            _visualizer = visualizer;
        }

        public void StartEmulation()
        {
            _engine.StartEmulation();
        }

        public void Visualize()
        {
            _visualizer.VisualizeTotalPopulation(_engine.GetTotalPopulationStats());

            _visualizer.VisualizeMalePopulation(_engine.GetMalePopulationStats());

            _visualizer.VisualizeFemalePopulation(_engine.GetFemalePopulationStats());

            _visualizer.VisualizeMaleComposition(_engine.GetMaleComposition());

            _visualizer.VisualizeFemaleComposition(_engine.GetFemaleComposition());
        }
    }
}
