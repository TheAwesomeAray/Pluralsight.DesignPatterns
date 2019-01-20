namespace Pluralsight.DesignPatterns.Factory
{
    public class MiniCooperFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new MiniCooper();
        }
    }
}
