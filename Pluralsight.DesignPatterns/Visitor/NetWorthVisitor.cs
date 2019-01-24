namespace Pluralsight.DesignPatterns.Visitor
{
    public class NetWorthVisitor : IVisitor
    {
        public decimal Total { get; set; }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        public void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        public void Visit(Loan loan)
        {
            Total -= loan.TotalOwed;
        }
    }
}
