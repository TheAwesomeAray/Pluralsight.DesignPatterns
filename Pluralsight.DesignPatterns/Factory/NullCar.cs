namespace Pluralsight.DesignPatterns.Factory
{
    internal class NullCar : IAuto
    {
        public NullCar()
        {
        }

        public void TurnOff()
        { }

        public void TurnOn()
        { }
    }
}