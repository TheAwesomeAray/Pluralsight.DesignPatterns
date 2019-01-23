using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Strategy
{
    class ShippingCostCalculatorService
    {
        IShippingCostStrategy _strategy;

        public ShippingCostCalculatorService(IShippingCostStrategy strategy)
        {
            _strategy = strategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return _strategy.Calculate(order);
        }
    }
}
