using System;
using System.Collections.Generic;

namespace Version_2_C
{
    [Serializable()]
    public class clsWorksList : List<clsWork>
    {
        //step 4 removed for singleton is this right?
        //private static clsNameComparer _NameComparer = new clsNameComparer();
        //step 4 removed for singleton is this right?
        //private static clsDateComparer _DateComparer = new clsDateComparer();
        private byte _SortOrder;

        public void AddWork(char prChoice)
        {
            clsWork lcWork = clsWork.NewWork(prChoice);
            if (lcWork != null)
            {
                Add(lcWork);
            }
        }

        public void EditWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                clsWork lcWork = (clsWork)this[prIndex];
                lcWork.EditDetails();
            }
            else
                throw new Exception("Sorry no work selected #" + Convert.ToString(prIndex));
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsWork lcWork in this)
            {
                lcTotal += lcWork.Value;
            }
            return lcTotal;
        }

        public void SortByName()
        {
            //make lasy and thread safe step 5 for Singleton.
            Sort(clsNameComparer.Instance);
            //Sort(_NameComparer);removed for singleton
            _SortOrder = 0;
        }

        public void SortByDate()
        {
            //make lasy and thread safe step 5 for Singleton.
            Sort(clsDateComparer.Instance);
            _SortOrder = 1;
        }

        public byte SortOrder
        {
            get { return _SortOrder; }
            set { _SortOrder = value; }
        }

    }
}
