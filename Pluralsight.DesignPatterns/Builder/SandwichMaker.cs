using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Builder
{
    public class SandwichMaker
    {
        private SandwichBuilder _builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSandwich()
        {
            _builder.CreateNewSandwich();
            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
            _builder.ApplyVegetables();
            _builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return _builder.GetSandwich();
        }
    }
}
