using System;

namespace Pluralsight.DesignPatterns.Decorator
{
    public static class DecoratorProgram
    {
        public static void Run()
        {
            Pizza largePizza = new LargePizza();
            var cheese = new Cheese(largePizza);
            var ham = new Ham(cheese);

            Console.WriteLine(ham.CalucateCost());
            Console.WriteLine(ham.GetDescription());
        }
    }
}
