using System;

namespace Pluralsight.DesignPatterns.Bridge
{
    class TermPaper : IManuscript
    {
        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public void Print(ITextFormat formatter)
        {
            Console.WriteLine(formatter.Format("Printing Term Paper"));
        }
    }
}
