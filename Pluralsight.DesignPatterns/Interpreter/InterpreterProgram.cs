using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Interpreter
{
    public static class InterpreterProgram
    {
        public static void Run()
        {
            var sandwhich = new Sandwhich(
                new WhiteBread(),
                new CondimentList(new List<Condiment> { new MayoCondiment() }),
                new IngredientList(new List<Ingredient> { new LettuceIngredient(), new ChickenIngredient() }),
                new CondimentList(new List<Condiment> { new KetchupCondiment() }),
                new WhiteBread());

            sandwhich.Interpret(new Context());
        }
    }
}
