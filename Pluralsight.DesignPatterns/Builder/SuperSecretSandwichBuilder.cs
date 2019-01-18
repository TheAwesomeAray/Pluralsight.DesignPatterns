using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Builder
{
    class SuperSecretSandwichBuilder : SandwichBuilder
    {
        public void CreateSandwhich()
        {
            _sandwich = new Sandwich();
            PrepareBread();
            ApplyMeatAndCheese();
            ApplyVegetables();
            AddCondiments();
        }

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
