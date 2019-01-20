using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Facade
{
    public class TemperatureLookUpFacade
    {
        private readonly GeoLookUpService _geoLookUpService;
        private readonly WeatherService _weatherService;
        private readonly EnglishMetricConverter _converter;

        public TemperatureLookUpFacade() : this(new GeoLookUpService(), new WeatherService(), new EnglishMetricConverter())
        {

        }

        public TemperatureLookUpFacade(GeoLookUpService geoLookUpService, WeatherService weatherService, EnglishMetricConverter converter)
        {
            _geoLookUpService = geoLookUpService;
            _weatherService = weatherService;
            _converter = converter;
        }

        public LocalTemp GetTemperature(string zipCode)
        {
            var localTemp = new LocalTemp();
            localTemp.City = _geoLookUpService.GetCityForZipCode(zipCode);
            localTemp.State = _geoLookUpService.GetStateForZipCode(zipCode);
            var coords = _geoLookUpService.GetCoordinatesForZipCode(zipCode);

            localTemp.Farenheight = _weatherService.GetTempFarenheight(coords.Latitude, coords.Longitude);
            localTemp.Celcius = _converter.FarenheitToCelcius(localTemp.Farenheight);

            return localTemp;
        }
    }

    public class LocalTemp
    {
        public double Farenheight { get; set; }
        public double Celcius { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
