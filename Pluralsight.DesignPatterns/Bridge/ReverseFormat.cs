using System;
using System.Linq;

namespace Pluralsight.DesignPatterns.Bridge
{
    public class ReverseFormat : ITextFormat
    {
        public string Format(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
