using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Builder
{
    public class ClubSandwichSandwichBuilder : SandwichBuilder
    {
        internal override void AddCondiments()
        {
            _sandwich.HasMayo = false;
            _sandwich.HasMustard = true;
        }

        internal override void ApplyVegetables()
        {
            _sandwich.Vegetables = new List<string>();
        }

        internal override void ApplyMeatAndCheese()
        {
            _sandwich.MeatType = MeatType.Steak;
            _sandwich.CheeseType = CheeseType.Cheddar;
        }

        internal override void PrepareBread()
        {
            _sandwich.BreadType = BreadType.White;
            _sandwich.IsToasted = true;
        }
    }
}
