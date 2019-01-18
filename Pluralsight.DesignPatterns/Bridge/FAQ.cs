using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Bridge
{
    public class FAQ : IManuscript
    {
        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; set; }

        public void Print(ITextFormat formatter)
        {
            Console.WriteLine(formatter.Format("Print FAQ"));
        }
    }
}
