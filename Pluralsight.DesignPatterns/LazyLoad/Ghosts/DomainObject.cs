using System;
using System.Collections;
using System.Diagnostics;

namespace Pluralsight.DesignPatterns.LazyLoad.Ghosts
{
    public abstract class DomainObject
    {
        private int Id { get; set; }
        private LoadStatus Status { get; set; }

        public DomainObject(int id)
        {
            Id = id;
        }

        public void MarkLoading()
        {
            Status = LoadStatus.Loading;
        }

        public void MarkLoaded()
        {
            Debug.Assert(Status == LoadStatus.Loading);

            Status = LoadStatus.Loaded;
        }

        public void Load()
        {
            if (Status != LoadStatus.Ghost)
                return;

            var dataRow = GetDataRow();
            LoadLine(dataRow);
        }

        private void LoadLine(ArrayList dataRow)
        {
            if (Status != LoadStatus.Ghost)
                return;

            MarkLoading();
            DoLoadLine(dataRow);
            MarkLoaded();
        }

        public abstract void DoLoadLine(ArrayList dataRow);

        public abstract ArrayList GetDataRow();
    }

    public enum LoadStatus
    {
        Ghost,
        Loading,
        Loaded
    }

}
