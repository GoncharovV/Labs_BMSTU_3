using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Demographic.WinForms
{
    class WinFormsDemographicVisualizer : IVisualizer
    {
        private readonly Chart total_population;
        private readonly Chart genders;
        private readonly Chart male_composition;
        private readonly Chart female_composition;

        public WinFormsDemographicVisualizer(
            Chart total_population,
            Chart genders,
            Chart male_composition,
            Chart female_composition
            )
        {
            this.total_population = total_population;
            this.genders = genders;
            this.male_composition = male_composition;
            this.female_composition = female_composition;
        }
        public void VisualizeFemaleComposition(List<PopulationGroup> data)
        {
            female_composition.Series.Clear();

            foreach (var group in data)
            {
                female_composition.Series.Add(new Series(group.GropName));
                female_composition.Series.Last().Points.Add(group.GroupSize);
            }

            female_composition.ChartAreas.First().AxisY.Maximum = data.Max(elem => elem.GroupSize) * 1.2f;
        }

        public void VisualizeFemalePopulation(List<YearResult> data)
        {
            Series female = genders.Series.Add("Female");
            female.ChartType = SeriesChartType.Spline;
            female.BorderWidth = 3;

            foreach (var yearResult in data)
            {
                female.Points.AddXY(yearResult.Year, yearResult.Value);
            }
        }

        public void VisualizeMaleComposition(List<PopulationGroup> data)
        {
            male_composition.Series.Clear();

            foreach (var group in data)
            {
                male_composition.Series.Add(new Series(group.GropName));
                male_composition.Series.Last().Points.Add(group.GroupSize);
            }

            male_composition.ChartAreas.First().AxisY.Maximum = data.Max(elem => elem.GroupSize) * 1.2f;
        }

        public void VisualizeMalePopulation(List<YearResult> data)
        {
            Series male = genders.Series.Add("Male");
            male.ChartType = SeriesChartType.Spline;
            male.BorderWidth = 4;

            foreach (var yearResult in data)
            {
                male.Points.AddXY(yearResult.Year, yearResult.Value);
            }
        }

        public void VisualizeTotalPopulation(List<YearResult> data)
        {
            total_population.Series.Clear();

            Series series = total_population.Series.Add("Population");
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 5;

            foreach (var yearResult in data)
            {
                series.Points.AddXY(yearResult.Year, yearResult.Value);
            }
        }
    }
}
