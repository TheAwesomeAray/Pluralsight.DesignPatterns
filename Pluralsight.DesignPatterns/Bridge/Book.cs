using System;

namespace Pluralsight.DesignPatterns.Bridge
{
    public class Book : IManuscript
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public virtual void Print(ITextFormat formatter)
        {
            Console.WriteLine(formatter.Format("Print Book"));
            Console.WriteLine();
        }
    }
}
