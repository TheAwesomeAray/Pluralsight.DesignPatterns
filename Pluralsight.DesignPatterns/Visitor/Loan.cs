namespace Pluralsight.DesignPatterns.Visitor
{
    public class Loan : IAsset
    {
        public decimal TotalOwed { get; set; }
        public decimal MinimumMonthlyPayment { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
