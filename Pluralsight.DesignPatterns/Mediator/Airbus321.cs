using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Mediator
{
    public class Airbus321 : Airplane
    {

        public override int Ceiling => 41000;

        public Airbus321(string callsign, IAirTrafficControl atc) : base(callsign, atc)
        { }

        public override bool IsTrailingGapAcceptible()
        {
            foreach (var aircraft in _acknowledgedAircract)
            {

            }

            return false;
        }
    }
}
