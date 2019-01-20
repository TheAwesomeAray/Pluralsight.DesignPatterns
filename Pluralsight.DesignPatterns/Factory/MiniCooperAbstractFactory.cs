using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Factory
{
    public class MiniCooperAbstractFactory : IAbstractFactory
    {
        MiniCooper mini;

        public MiniCooperAbstractFactory()
        {
            mini = new MiniCooper();
        }

        public IAuto CreateEconomyCar()
        {
            mini.AddEconomyPackage();
            return mini;
        }

        public IAuto CreateLuxuryCar()
        {
            mini.AddLuxuryPackage();
            return mini;
        }

        public IAuto CreateSportsCar()
        {
            mini.AddSportsPackage();
            return mini;
        }
    }
}
