using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Observer
{
    public static class SampleData
    {
        public static List<Stock> Stocks = new List<Stock>()
        {
            new Stock() { Symbol = "GOOG", Price = 10.00m },
            new Stock() { Symbol = "MSFT", Price = 12.00m },
            new Stock() { Symbol = "GOOG", Price = 11.25m },
            new Stock() { Symbol = "GOOG", Price = 9.00m },
            new Stock() { Symbol = "MSFT", Price = 10.25m }
        };
    }
}