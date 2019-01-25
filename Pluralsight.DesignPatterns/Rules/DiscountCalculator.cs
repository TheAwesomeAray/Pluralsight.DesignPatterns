using System;
using System.Collections.Generic;
using System.Text;
using Pluralsight.DesignPatterns.LazyLoad;

namespace Pluralsight.DesignPatterns.Rules
{
    public class DiscountCalculator
    {
        public List<IDiscountRule> DiscountRules { get; set; } = new List<IDiscountRule>();

        public DiscountCalculator()
        {
            DiscountRules.Add(new BirthdayDiscountRule());
            DiscountRules.Add(new SeniorDiscountRule());
        }

        public decimal CalculateDiscountPercentage(Customer customer)
        {
            decimal discount = 0;

            foreach (var _rule in DiscountRules)
                discount = Math.Max(discount, _rule.CalculateCustomerDiscount(customer));

            return discount;
        }
    }

    public class BirthdayDiscountRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            if (customer.DateOfBirth.Month == DateTime.Today.Month &&
                customer.DateOfBirth.Day == DateTime.Today.Day)
                return .1m;

            return 0;
        }
    }

    public class SeniorDiscountRule : IDiscountRule
    {
        public decimal CalculateCustomerDiscount(Customer customer)
        {
            if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
                return .1m;

            return 0;
        }
    }

}
