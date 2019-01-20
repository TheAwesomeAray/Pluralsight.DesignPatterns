using System;

namespace Pluralsight.DesignPatterns.Factory
{
    internal class MiniCooper : IAuto
    {
        public MiniCooper()
        {
        }

        public void TurnOff()
        {
            Console.WriteLine("Mini is off.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Mini is on and running!");
        }

        internal void AddEconomyPackage()
        {
            throw new NotImplementedException();
        }

        internal void AddLuxuryPackage()
        {
            throw new NotImplementedException();
        }

        internal void AddSportsPackage()
        {
            throw new NotImplementedException();
        }
    }
}