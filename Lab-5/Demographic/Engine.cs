using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class Engine : IEngine
    {
        public int StartYear { get; private set; }
        public int EndYear { get; private set; }
        public int StartPopulation { get; private set; }

        private readonly DeathRules _deathRules;

        private readonly List<Person> population = new List<Person>();

        public event EventHandler<int> YearTick;

        public Engine (IDataExtractor dataExtractor, int startYear, int endYear, int startPopulation)
        {
            StartPopulation = startPopulation;
            StartYear = startYear;
            EndYear = endYear;

            _deathRules = dataExtractor.GetDeathRules();

            InitPopulation(dataExtractor.GetInitialAges());
        }

        public void StartEmulation()
        {
            System.Diagnostics.Debug.WriteLine("Emulation has been started...");

            for (int year = StartYear; year <= EndYear; year++)
            {
                YearTick?.Invoke(this, year);
            }

            System.Diagnostics.Debug.WriteLine("Population: " + population.Count(person => person.IsAlive));
        }

        void InitPopulation((int age, double ratio)[] initialAges)
        {
            int totalPersonCount = StartPopulation / Constants.PERSON_MULTIPLIER;

            foreach (var initalAge in initialAges)
            {
                int currentAgePersonCount = (int)Math.Round(totalPersonCount / 1000 * initalAge.ratio);

                for (int i = 0; i < currentAgePersonCount; i++)
                {
                    int birthYear = StartYear - initalAge.age;

                    Person person = CreatePerson(birthYear, initalAge.age);

                    population.Add(person);
                }
            }
        }

        public void ChildBirth(object sender, int year)
        {
            Person person = CreatePerson(year, 0);

            population.Add(person);

            System.Diagnostics.Debug.WriteLine("[LOG] BIRTH " + year);
        }

        private Person CreatePerson(int birthYear, int age)
        {
            Genders gender = ProbabilityCalculator.IsEventHappened(Constants.FEMALE_RATIO) ?
                Genders.Female : Genders.Male;
            
            Person person = new Person(birthYear, age, gender, _deathRules);

            this.YearTick += person.PersonYearTick;
            person.ChildBith += ChildBirth;

            return person;
        }

        public List<YearResult> GetTotalPopulationStats()
        {
            List<YearResult> result = new List<YearResult>();

            for (int year = StartYear; year <= EndYear; year++)
            {
                int count = population
                    .Count(person => person.BirthYear <= year
                        && (person.DeathYear > year || person.DeathYear == null));

                result.Add(new YearResult(year, count));
            }

            return result;
        }

        public List<YearResult> GetMalePopulationStats()
        {
            List<YearResult> result = new List<YearResult>();

            for (int year = StartYear; year <= EndYear; year++)
            {
                int count = population
                    .Count(person => person.BirthYear <= year 
                        && (person.DeathYear > year || person.DeathYear == null) 
                        && person.Gender == Genders.Male);

                result.Add(new YearResult(year, count));
            }

            return result;
        }

        public List<YearResult> GetFemalePopulationStats()
        {
            List<YearResult> result = new List<YearResult>();

            for (int year = StartYear; year <= EndYear; year++)
            {
                int count = population
                    .Count(person => person.BirthYear <= year
                        && (person.DeathYear > year || person.DeathYear == null) 
                        && person.Gender == Genders.Female);

                result.Add(new YearResult(year, count));
            }

            return result;
        }

        public List<PopulationGroup> GetMaleComposition()
        {
            return new List<PopulationGroup>
            {
                new PopulationGroup("0-18", GetPopulationGroupCount(0, 18, Genders.Male)),
                new PopulationGroup("19-44", GetPopulationGroupCount(19, 44, Genders.Male)),
                new PopulationGroup("45-65", GetPopulationGroupCount(45, 65, Genders.Male)),
                new PopulationGroup("66-100", GetPopulationGroupCount(66, 100, Genders.Male))
            };
        }

        public List<PopulationGroup> GetFemaleComposition()
        {
           return new List<PopulationGroup>
            {
                new PopulationGroup("0-18", GetPopulationGroupCount(0, 18, Genders.Female)),
                new PopulationGroup("19-44", GetPopulationGroupCount(19, 44, Genders.Female)),
                new PopulationGroup("45-65", GetPopulationGroupCount(45, 65, Genders.Female)),
                new PopulationGroup("66-100", GetPopulationGroupCount(66, 100, Genders.Female))
            };
        }

        private int GetPopulationGroupCount(int startAge, int endAge, Genders gender)
        {
            return population.Count(person => person.Gender == gender 
                && person.Age >= startAge
                && person.Age <= endAge
                && person.IsAlive);
        }

    }
}
