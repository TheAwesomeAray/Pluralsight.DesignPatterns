using System.IO;

namespace Pluralsight.DesignPatterns.Template
{
    public abstract class OrderShipment
    {
        public string ShippingAddress { get; set; }
        public string Label { get; set; }

        public void Ship(TextWriter writer)
        {
            VerifyShippingData();
            SetShippingLabelFromCarrier();
            PrintLabel(writer);
        }

        public abstract void VerifyShippingData();
        public abstract void SetShippingLabelFromCarrier();
        public abstract void PrintLabel(TextWriter writer);
    }
}
