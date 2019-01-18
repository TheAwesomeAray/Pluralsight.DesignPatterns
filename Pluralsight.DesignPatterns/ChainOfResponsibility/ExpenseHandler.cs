using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.ChainOfResponsibility
{
    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler next);
    }

    public class ExpenseHandler : IExpenseHandler
    {
        private Employee _employee;
        private IExpenseHandler _next;

        public ExpenseHandler(Employee employee)
        {
            _employee = employee;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            var response = _employee.ApproveExpense(expenseReport);

            if (response == ApprovalResponse.BeyondApprovalLimit)
                return _next.Approve(expenseReport);

            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
    }
}
