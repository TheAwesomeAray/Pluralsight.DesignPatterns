using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Interpreter
{
    public interface Expression
    {
        void Interpret(Context context);
    }

    public class Context
    {
        public string Output { get; set; }
    }
}
