using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.ChainOfResponsibility
{
    public class ExpenseReport : IExpenseReport
    {
        public decimal Total { get; set; }
    }
}
