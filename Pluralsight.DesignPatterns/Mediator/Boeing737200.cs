using System;

namespace Pluralsight.DesignPatterns.Mediator
{
    public class Boeing737200 : Airplane
    {
        public override int Ceiling => throw new NotImplementedException();

        public Boeing737200(string callsign, IAirTrafficControl atc) : base (callsign, atc)
        { }

        public override bool IsTrailingGapAcceptible()
        {
            throw new NotImplementedException();
        }
    }
}
