using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Employee> Employees { get; }
        IRepository<TimeCard> TimeCards { get; }
        void Commit();
    }
}
