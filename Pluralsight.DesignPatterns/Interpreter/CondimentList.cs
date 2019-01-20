using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Interpreter
{
    public class CondimentList : Expression
    {
        private List<Condiment> _condiments;

        public CondimentList(List<Condiment> condiments)
        {
            _condiments = condiments;
        }

        public void Interpret(Context context)
        {
            foreach (var condiment in _condiments)
                condiment.Interpret(context);
        }
    }
}