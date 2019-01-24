using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(BankAccount bankAccount);
        void Visit(RealEstate realEstate);
        void Visit(Loan loan);
    }

    public interface IAsset
    {
        void Accept(IVisitor visitor);
    }

}
