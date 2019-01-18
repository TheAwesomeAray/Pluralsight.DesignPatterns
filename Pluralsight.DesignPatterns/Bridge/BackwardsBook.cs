using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.DesignPatterns.Bridge
{
    class BackwardsBook : Book
    {
        //Bad - replace with bridge
        //public override void Print()
        //{
        //    Console.WriteLine($"Title: {new string(Title.Reverse().ToArray())}");
        //    Console.WriteLine($"Author: {new string(Author.Reverse().ToArray())}");
        //    Console.WriteLine($"Text: {new string(Text.Reverse().ToArray())}");
        //    Console.WriteLine();
        //}
    }
}
