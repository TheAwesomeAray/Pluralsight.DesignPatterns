namespace Pluralsight.DesignPatterns.LazyLoad.VirtualProxy
{
    public class OrderProxy : Order
    {
        public override Customer Customer
        {
            get
            {
                if (base.Customer == null)
                    return base.Customer = new Customer();

                return base.Customer;
            }
            set
            {
                base.Customer = value;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}