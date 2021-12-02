using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demographic;
using Demographic.FileOperations;
using System.Windows.Forms.DataVisualization.Charting;

namespace Demographic.WinForms
{
    public partial class Form1 : Form
    {
        private string initialAgesPath = @"G:\Downloads\InitialAge.csv";
        private string deathRulesPath = @"G:\Downloads\DeathRules.csv";
        public Form1()
        {
            InitializeComponent();

            ClearCharts();

            total_population.Titles.Add("Total Population");
            genders_chart.Titles.Add("Genders");
            male_composition.Titles.Add("Male composition");
            female_composition.Titles.Add("Female composition");

            start_year.Text = "1970";
            end_year.Text = "2021";
            start_population.Text= "10 000 000";

            total_population.ChartAreas.First().AxisX.MajorGrid.LineColor = Color.FromArgb(70, Color.Gray);
            total_population.ChartAreas.First().AxisY.MajorGrid.LineColor = Color.FromArgb(70, Color.Gray);

            genders_chart.ChartAreas.First().AxisX.MajorGrid.LineColor = Color.FromArgb(70, Color.Gray);
            genders_chart.ChartAreas.First().AxisY.MajorGrid.LineColor = Color.FromArgb(70, Color.Gray);

            initial_age_textbox.Text = initialAgesPath;
            death_rules_textbox.Text = deathRulesPath;

            init_ages_dialog.InitialDirectory = @"C:\";
            death_rules_dialog.InitialDirectory = @"C:\";
        }

        private void start_bttn_Click(object sender, EventArgs e)
        {
            ClearCharts();

            try
            {
                int startYear = int.Parse(start_year.Text);
                int endYear = int.Parse(end_year.Text);
                int startPopulation = int.Parse(start_population.Text.Replace(" ", ""));

                IDataExtractor dataExtractor = new DemographicDataExtractor(initialAgesPath, deathRulesPath);
                IVisualizer visualizer = new WinFormsDemographicVisualizer(total_population,
                    genders_chart, male_composition, female_composition);
                IEngine engine = new Engine(dataExtractor, startYear, endYear, startPopulation);

                DemographicFacade facade = new DemographicFacade(engine, visualizer);


                total_population.ChartAreas.First().AxisX.Minimum = startYear;
                genders_chart.ChartAreas.First().AxisX.Minimum = startYear;

                facade.StartEmulation();

                facade.Visualize();
            }
            catch(Exception _)
            {
                MessageBox.Show("Wrong data", "Error");
            }
        }

        private void ClearCharts()
        {
            total_population.Series.Clear();
            genders_chart.Series.Clear();
            male_composition.Series.Clear();
            female_composition.Series.Clear();
        }

        private void init_ages_btn_Click(object sender, EventArgs e)
        {
            init_ages_dialog.ShowDialog();
            initialAgesPath = init_ages_dialog.FileName;
            initial_age_textbox.Text = initialAgesPath;
        }

        private void death_rules_btn_Click(object sender, EventArgs e)
        {
            death_rules_dialog.ShowDialog();
            deathRulesPath = death_rules_dialog.FileName;
            death_rules_textbox.Text = deathRulesPath;
        }
    }
}
