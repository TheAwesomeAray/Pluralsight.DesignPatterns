using System;
using System.IO;

namespace Pluralsight.DesignPatterns.Template
{
    public class UpsOrderShipment : OrderShipment
    {
        public override void PrintLabel(TextWriter writer)
        {
            writer.Write(Label);
        }

        public override void SetShippingLabelFromCarrier()
        {
            Label = $"UPS: {ShippingAddress}";
        }

        public override void VerifyShippingData()
        {
            if (string.IsNullOrEmpty(ShippingAddress))
            {
                throw new ApplicationException("Invalid Address");
            }
        }
    }
}
