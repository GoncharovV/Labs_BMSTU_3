using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class Person
    {
        public int BirthYear { get; }

        public int Age { get; private set; }

        public Genders Gender { get; }

        public bool IsAlive { get; private set; }

        public int? DeathYear { get; private set; }

        public event EventHandler<int> ChildBith;

        private DeathRules _deathRules;

        public Person(int birthYear, int age, Genders gender, DeathRules deathRules)
        {
            BirthYear = birthYear;
            Age = age;
            Gender = gender;
            _deathRules = deathRules;
            IsAlive = true;
        }

        public void PersonYearTick(object sender, int year) 
        {
            if (IsAlive)
            {
                Age++;

                CheckLifeStatus();

                if (IsAlive)
                {
                    CheckChildBirth(year);
                }
                else
                {
                    Engine engine = (Engine)sender;
                    
                    engine.YearTick -= this.PersonYearTick;
                    this.ChildBith -= engine.ChildBirth;

                    DeathYear = year;

                    System.Diagnostics.Debug.WriteLine("[LOG] DETH " + year + " " + Age);
                }                
            }
        }

        private void CheckLifeStatus()
        {
            IsAlive = !ProbabilityCalculator.IsEventHappened(_deathRules.GetDeathProbability(Age, Gender));
        }

        private void CheckChildBirth(int currentYear)
        {
            if (IsAlive && Gender == Genders.Female && Age >= Constants.MIN_BIRTH_AGE && Age <= Constants.MAX_BIRTH_AGE)
            {
                bool child = ProbabilityCalculator.IsEventHappened(Constants.BIRTH_PROBABILITY);

                if (child)
                {
                    ChildBith?.Invoke(this, currentYear);
                }
            }
        }

    }
}
