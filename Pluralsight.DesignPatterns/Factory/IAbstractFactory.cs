using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Factory
{
    public interface IAbstractFactory
    {
        IAuto CreateEconomyCar();
        IAuto CreateSportsCar();
        IAuto CreateLuxuryCar();
    }
}
