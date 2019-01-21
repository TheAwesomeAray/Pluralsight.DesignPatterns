namespace Pluralsight.DesignPatterns.Mediator
{
    public interface IAirTrafficControl
    {
        void ReceiveAirCraftLocation(Airplane airplane);
        void RegisterAircraftUnderGuidance(Airplane airplane);
    }
}
