using System;

namespace Pluralsight.DesignPatterns.Facade
{
    public class EnglishMetricConverter
    {
        public EnglishMetricConverter()
        {
        }

        internal double FarenheitToCelcius(double farenheit)
        {
            return Math.Floor((farenheit - 32) * (5 / (double)9));
        }
    }
}