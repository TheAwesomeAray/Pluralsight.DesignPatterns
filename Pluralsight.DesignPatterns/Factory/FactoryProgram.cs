using System;
using System.Reflection;

namespace Pluralsight.DesignPatterns.Factory
{
    public static class FactoryProgram
    {
        public static void Run()
        {
            var carName = Console.ReadLine();

            var factory = new SimpleFactory();
            var car = factory.CreateInstance(carName);
            car.TurnOn();
            car.TurnOff();
        }

        public static void RunRefactor()
        {
            IAutoFactory factory = LoadFactory();
            var auto = factory.CreateAutomobile();
            auto.TurnOn();
            auto.TurnOff();
        }

        public static void RunAbstractFactory()
        {
            IAbstractFactory factory = LoadAbstractFactory();
            var car = factory.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

            car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            car = factory.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

        }

        private static IAbstractFactory LoadAbstractFactory()
        {
            throw new NotImplementedException();
        }

        static IAutoFactory LoadFactory()
        {
            string factoryName = Settings.Instance.FactoryName;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
