namespace Pluralsight.DesignPatterns.Visitor
{
    public class MonthlyIncomeVisitor : IVisitor
    {
        public decimal MonthlyIncome { get; set; }

        public void Visit(BankAccount bankAccount)
        {
            MonthlyIncome += (bankAccount.Amount * bankAccount.MonthlyInterest);
        }

        public void Visit(RealEstate realEstate)
        {
            MonthlyIncome += realEstate.MonthlyRent;
        }

        public void Visit(Loan loan)
        {
            MonthlyIncome -= loan.MinimumMonthlyPayment;
        }
    }
}
