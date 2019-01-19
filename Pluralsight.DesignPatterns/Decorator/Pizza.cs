using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Decorator
{
    public abstract class Pizza
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract decimal CalucateCost();

    }
}
