using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Strategy
{
    public interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}
