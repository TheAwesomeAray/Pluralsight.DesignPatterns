using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.State
{
    public class ActiveWorkItem : ICommands
    {
        private WorkItem workItem;

        public ActiveWorkItem(WorkItem workItem)
        {
            this.workItem = workItem;
        }

        public void Delete()
        {
            Console.WriteLine("Work item is active and cannot be deleted");
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public void Resolve()
        {
            workItem.WorkItemState = WorkItemState.Resolved;
        }
    }
}
