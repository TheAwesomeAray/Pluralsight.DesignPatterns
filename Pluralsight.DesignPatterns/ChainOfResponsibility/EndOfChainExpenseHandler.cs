using System;

namespace Pluralsight.DesignPatterns.ChainOfResponsibility
{
    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        private EndOfChainExpenseHandler() { }

        public static EndOfChainExpenseHandler Instance { get; } = new EndOfChainExpenseHandler();

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            return ApprovalResponse.Denied;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new NotImplementedException();
        }
    }
}
