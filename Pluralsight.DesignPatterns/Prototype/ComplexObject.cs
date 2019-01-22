using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Prototype
{
    public class ComplexObject : ICloneable
    {
        internal ComplexObject(string param1, string param2, string param3)
        {

        }

        internal ComplexObject(string param1, string param2, string param3, string param4)
        {

        }

        public object Clone()
        {
            //Outside of assembly, constructors cannot be used. Allow users to be able to create copies
            return MemberwiseClone();
        }
    }
}
