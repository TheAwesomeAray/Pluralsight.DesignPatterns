using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Bridge
{
    class NormalFormat : ITextFormat
    {
        public string Format(string input)
        {
            return input;
        }
    }
}
