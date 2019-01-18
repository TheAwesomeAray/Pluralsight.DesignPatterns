namespace Pluralsight.DesignPatterns.ChainOfResponsibility
{
    public class Employee : IExpenseApprover
    {
        private decimal _approvalLimit;

        public Employee(decimal approvalLimit)
        {
            _approvalLimit = approvalLimit;
        }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            if (expenseReport.Total > _approvalLimit)
                return ApprovalResponse.BeyondApprovalLimit;

            return ApprovalResponse.Approve;
        }
    }
}
