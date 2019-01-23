using System;
using System.Collections.Generic;
using System.Text;

namespace Pluralsight.DesignPatterns.State
{
    public class WorkItem
    {
        private  WorkItem()
        { }

        public string Title { get; set; }
        public string Description { get; set; }
        private WorkItemState _state;

        public WorkItemState WorkItemState
        {
            get { return _state; }
            set
            {
                _state = value;
                
                switch (_state)
                {
                    case WorkItemState.Proposed:
                        State = new ProposedWorkItem(this);
                        break;
                    case WorkItemState.Active:
                        State = new ActiveWorkItem(this);
                        break;
                    case WorkItemState.Resolved:
                        State = new ResolvedWorkItem(this);
                        break;
                }
            }
        }

        private ICommands State { get; set; }

        public void Open()
        {
            State.Open();
        }
        public void Resolve()
        {
            State.Resolve();
        }
        public void Delete()
        {
            State.Delete();
        }
    }

    public enum WorkItemState
    {
        Proposed,
        Active,
        Resolved,
        Closed
    }
}
