using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Decorator
{
    public class MediumPizza : Pizza
    {
        public override decimal CalucateCost()
        {
            return 6;
        }

        public override string GetDescription()
        {
            return "Medium Pizza";
        }
    }
}
