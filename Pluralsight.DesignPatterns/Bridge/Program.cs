using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IManuscript> documents = new List<IManuscript>();
            documents.Add(new Book());
            documents.Add(new FAQ());
            documents.Add(new TermPaper());

            foreach (var doc in documents)
                doc.Print(new NormalFormat());

            Console.ReadKey();
        }
    }
}
