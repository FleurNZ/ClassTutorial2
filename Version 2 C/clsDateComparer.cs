using System;
using System.Collections.Generic;

namespace Version_2_C
{
    
    //step 3 singleton chnage to sealed
    sealed class clsDateComparer : IComparer<clsWork>
    {
        //step 2 singleton add
        public static readonly clsDateComparer Instance = new clsDateComparer();
        public int Compare(clsWork x, clsWork y)
        {
            

            return x.Date.CompareTo(y.Date);

            
        }
       // Step 1 singleton add
        private clsDateComparer()
        { }
    }

    ///weird two here so commented out.

    //class clsDDateComparer : IComparer<clsWork>
    //{
    //    public int Compare(clsWork x, clsWork y)
    //    {
    //        //DateTime lcDateX = x.Date;
    //        //DateTime lcDateY = y.Date;

    //        return y.Date.CompareTo(x.Date);

    //        //return lcDateX.CompareTo(lcDateY);
    //    }
    //}
}
