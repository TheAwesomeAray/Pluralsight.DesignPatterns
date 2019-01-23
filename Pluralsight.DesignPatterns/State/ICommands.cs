using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.State
{
    public interface ICommands
    {
        void Open();
        void Resolve();
        void Delete();
    }
}
