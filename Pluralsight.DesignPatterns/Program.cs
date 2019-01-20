using Pluralsight.DesignPatterns.Bridge;
using Pluralsight.DesignPatterns.Builder;
using Pluralsight.DesignPatterns.ChainOfResponsibility;
using Pluralsight.DesignPatterns.Command;
using Pluralsight.DesignPatterns.Composite;
using Pluralsight.DesignPatterns.Decorator;
using Pluralsight.DesignPatterns.Facade;
using Pluralsight.DesignPatterns.Factory;
using Pluralsight.DesignPatterns.Interpreter;
using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {

            InterpreterProgram.Run();
            Console.ReadLine();
        }

        public static void ChainOfCommand()
        {
            ExpenseHandler william = new ExpenseHandler(new Employee(0));
            ExpenseHandler mary = new ExpenseHandler(new Employee(1000));
            ExpenseHandler victor = new ExpenseHandler(new Employee(5000));
            ExpenseHandler paula = new ExpenseHandler(new Employee(20000));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            paula.RegisterNext(paula);

            Console.WriteLine("Please enter the expense amount;");
            var expenseAmount = decimal.Parse(Console.ReadLine());

            var response = william.Approve(new ExpenseReport() { Total = expenseAmount });

            Console.WriteLine(response);
            Console.ReadKey();
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
