using System;

namespace Pluralsight.DesignPatterns.Facade
{
    public class GeoLookUpService
    {
        internal string GetCityForZipCode(string zipCode)
        {
            return "Helena";
        }

        internal string GetStateForZipCode(string zipCode)
        {
            return "Alabama";
        }

        internal CoordinateGroup GetCoordinatesForZipCode(string zipCode)
        {
            return new CoordinateGroup() { Latitude = "-75.1223434", Longitude = "53.4536543" };
        }
    }
}