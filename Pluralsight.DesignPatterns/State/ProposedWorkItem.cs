using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.State
{
    class ProposedWorkItem : ICommands
    {
        private WorkItem workItem;

        public ProposedWorkItem(WorkItem workItem)
        {
            this.workItem = workItem;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Resolve()
        {
            throw new NotImplementedException();
        }
    }
}
