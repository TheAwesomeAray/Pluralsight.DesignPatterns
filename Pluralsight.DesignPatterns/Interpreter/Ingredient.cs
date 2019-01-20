namespace Pluralsight.DesignPatterns.Interpreter
{
    public interface Ingredient : Expression { }

    public class TomatoIngredient : Ingredient
    {
        public void Interpret(Context context)
        {
            context.Output += " Tomato ";
        }
    }

    public class LettuceIngredient : Ingredient
    {
        public void Interpret(Context context)
        {
            context.Output += " Lettuce ";
        }
    }


    public class ChickenIngredient : Ingredient
    {
        public void Interpret(Context context)
        {
            context.Output += " Chicken ";
        }
    }
}