using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Interpreter
{
    public interface Condiment : Expression { }

    public class MayoCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += " Mayo ";
        }
    }

    public class MustardCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += " Mustard ";
        }
    }

    public class KetchupCondiment : Condiment
    {
        public void Interpret(Context context)
        {
            context.Output += " Ketchup ";
        }
    }
}
