using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Decorator
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base (pizza)
        {
            Description = "Ham";
        }

        public override decimal CalucateCost()
        {
            return _pizza.CalucateCost() + 1.5m;
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }
    }
}
