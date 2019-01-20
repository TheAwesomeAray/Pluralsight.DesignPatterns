using System;

namespace Pluralsight.DesignPatterns.Facade
{
    public static class FacadeProgram
    {
        public static void Run()
        {
            string zipCode = "35080";

            GeoLookUpService geoLookUpService = new GeoLookUpService();
            var city = geoLookUpService.GetCityForZipCode(zipCode);
            var state = geoLookUpService.GetStateForZipCode(zipCode);
            var coords = geoLookUpService.GetCoordinatesForZipCode(zipCode);

            WeatherService weatherService = new WeatherService();
            var farenheit = weatherService.GetTempFarenheight(coords.Latitude, coords.Longitude);
            var converter = new EnglishMetricConverter();
            var celcius = converter.FarenheitToCelcius(farenheit);

            Console.WriteLine($"The current temperature is {farenheit}F /{celcius}C in {city}, {state}");
        }

        public static void RunRefactor()
        {
            string zipCode = "35080";

            var facade = new TemperatureLookUpFacade();
            var localTemp = facade.GetTemperature(zipCode);

            Console.WriteLine($"The current temperature is {localTemp.Farenheight}F / {localTemp.Celcius}C " +
                $"in {localTemp.City}, {localTemp.State}");
        }
    }
}
