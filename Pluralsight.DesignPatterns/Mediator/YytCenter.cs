using System;
using System.Collections.Generic;
using System.Linq;

namespace Pluralsight.DesignPatterns.Mediator
{
    class YytCenter : IAirTrafficControl
    {
        private readonly IList<Airplane> _aircraftUnderGuidance = new List<Airplane>();

        public void ReceiveAirCraftLocation(Airplane reportingAircraft)
        {
            foreach (var currentAircraftUnderGuidance in _aircraftUnderGuidance.Where(a => a != reportingAircraft))
            {
                if (Math.Abs(currentAircraftUnderGuidance.Altitude - reportingAircraft.Altitude) > 1000)
                {
                    reportingAircraft.Climb(1000);
                    currentAircraftUnderGuidance.WarnOfAirspaceIntrusion(reportingAircraft);
                }
            }
        }

        public void RegisterAircraftUnderGuidance(Airplane airplane)
        {
            if (!_aircraftUnderGuidance.Contains(airplane))
                _aircraftUnderGuidance.Add(airplane);
        }
    }
}
