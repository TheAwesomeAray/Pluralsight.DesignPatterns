using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Decorator
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base (pizza)
        {
            Description = "Cheese";
        }

        public override decimal CalucateCost()
        {
            return _pizza.CalucateCost() + 1.25m;
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }
    }
}
