using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demographic
{
    public interface IDataExtractor
    {
        (int age, double ratio)[] GetInitialAges();

        DeathRules GetDeathRules();
    }
}