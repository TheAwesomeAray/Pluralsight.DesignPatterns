using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Builder
{
    public abstract class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich GetSandwich()
        {
            return _sandwich;
        }

        public void CreateNewSandwich()
        {
            _sandwich = new Sandwich();
        }

        internal abstract void AddCondiments();
        internal abstract void ApplyVegetables();
        internal abstract void ApplyMeatAndCheese();
        internal abstract void PrepareBread();
    }
}
