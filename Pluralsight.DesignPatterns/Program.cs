using Pluralsight.DesignPatterns.Bridge;
using Pluralsight.DesignPatterns.Builder;
using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Builder();
        }

        public static void Builder()
        {
            var builder = new SandwichMaker(new ClubSandwichSandwichBuilder());
            builder.BuildSandwich();
            var sandwich = builder.GetSandwich();
        }

        public static void Bridge()
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
