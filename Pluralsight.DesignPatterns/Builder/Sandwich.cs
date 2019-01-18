using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Builder
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {

        }
    }

    public enum BreadType
    {
        Wheat,
        White
    }

    public enum MeatType
    {
        Chicken,
        Steak
    }

    public enum CheeseType
    {
        Cheddar,
        Provolone
    }
}
