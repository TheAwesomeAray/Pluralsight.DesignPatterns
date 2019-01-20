using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Interpreter
{
    //BNF:
    // <sandwhich> ::= <bread> <condimentList> <ingredientList> <condimentList> <bread>
    // <condimentList> ::= { <condiment> }
    // <ingredientList> ::= { <ingredient> }
    // <bread> ::= <whitebread> | <wheatbread>
    // <condiment> ::= <mayoCondiment> | <mustardCondiment> | <ketchupCondiment>
    // <ingredient> ::= <lettuceIngredient> | <tomatoIngredient> | <chickenIngredient>
    public class Sandwhich : Expression
    {
        private readonly Bread _topBread;
        private readonly CondimentList _topCondiments;
        private readonly IngredientList _ingredients;
        private readonly CondimentList _bottomCondiments;
        private readonly Bread _bottomBread;

        public Sandwhich(Bread topBread, CondimentList topCondiments, IngredientList ingredients, CondimentList bottomCondiments,
            Bread bottomBread)
        {
            _topBread = topBread;
            _topCondiments = topCondiments;
            _ingredients = ingredients;
            _bottomCondiments = bottomCondiments;
            _bottomBread = bottomBread;
        }

        public void Interpret(Context context)
        {
            context.Output += "|";
            _topBread.Interpret(context);
            context.Output += "|";
            context.Output += "<--";
            _topCondiments.Interpret(context);
            context.Output += "-";
            _ingredients.Interpret(context);
            context.Output += "-";
            _bottomCondiments.Interpret(context);
            context.Output += "-->";
            context.Output += "|";
            _bottomBread.Interpret(context);
            context.Output += "|";

            Console.WriteLine(context.Output);
        }
    }
}
