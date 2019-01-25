using Pluralsight.DesignPatterns.LazyLoad;

namespace Pluralsight.DesignPatterns.Rules
{
    public interface IDiscountRule
    {
        decimal CalculateCustomerDiscount(Customer customer);
    }
}