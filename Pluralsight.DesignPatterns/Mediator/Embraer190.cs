using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Mediator
{
    public class Embraer190 : Airplane
    {
        public Embraer190(string callsign, IAirTrafficControl atc) : base(callsign, atc)
        { }

        public override int Ceiling => 50000;

        public override bool IsTrailingGapAcceptible()
        {
            throw new NotImplementedException();
        }
    }
}
