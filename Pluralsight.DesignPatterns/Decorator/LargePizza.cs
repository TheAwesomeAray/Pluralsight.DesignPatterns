using System;

namespace Pluralsight.DesignPatterns.Decorator
{
    public class LargePizza : Pizza
    {
        public override decimal CalucateCost()
        {
            return 9;
        }

        public override string GetDescription()
        {
            return "Large Pizza";
        }
    }
}
