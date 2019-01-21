using System;
using System.Collections.Generic;

namespace Pluralsight.DesignPatterns.Mediator
{
    public abstract class Airplane
    {
        private int _currentAltitude;
        private IAirTrafficControl _atc;
        protected IList<Airplane> _acknowledgedAircract;
        public string Callsign { get; private set; }
        public abstract int Ceiling { get; }

        private int _altitude;

        public int Altitude
        {
            get { return _altitude; }
            set
            {
                _altitude = value;
                _atc.ReceiveAirCraftLocation(this);
            }
        }


        public Airplane(string callsign, IAirTrafficControl atc)
        {
            Callsign = callsign;
            _atc = atc;
            _atc.RegisterAircraftUnderGuidance(this);
        }

        internal void WarnOfAirspaceIntrusion(Airplane reportingAircraft)
        {
            //Do something in response to warning
        }

        public void Ackknowledges(Airplane airplane)
        {
            _acknowledgedAircract.Add(airplane);
        }
        
        public abstract bool IsTrailingGapAcceptible();

        public void Climb(int feet)
        {
            Altitude += feet;
        }

        
        


    }
}