using System;
using System.Collections.Generic;

namespace Version_2_C
{
    //step 3 singleton change class type to sealed
    sealed class clsNameComparer : IComparer<clsWork>
    {
        //step two for singleton
        public static readonly clsNameComparer Instance = new clsNameComparer();
        public int Compare(clsWork x, clsWork y)
        {
            string lcNameX = x.Name;
            string lcNameY = y.Name;

            return lcNameX.CompareTo(lcNameY);
        }
        //step one for singleton
        private clsNameComparer()
        { }
    }
}
