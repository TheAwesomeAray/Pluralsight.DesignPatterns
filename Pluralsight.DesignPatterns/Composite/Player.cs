using System;

namespace Pluralsight.DesignPatterns.Composite
{
    public class Player : ILoot
    {
        public string Name { get; set; }
        public decimal Gold { get; set; }

        public void ReceiveLoot(decimal gold)
        {
            Gold += Math.Round(gold);
        }

        public void Stats()
        {
            Console.WriteLine($"{Name} has {Gold} gold coins");
        }
    }
}
