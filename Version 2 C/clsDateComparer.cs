using System;
using System.Collections.Generic;

namespace Version_2_C
{
    
    //step 3 singleton chnage to sealed
    public sealed class clsDateComparer : IComparer<clsWork>
    {
        //this singleton has been updated slight dif to other this one is correct.
        //step 2 singleton add
        private static readonly clsDateComparer _Instance = new clsDateComparer();

        //step 2 singleton
        public static clsDateComparer Instance
        {
            get
            {
                return _Instance;
            }
        }

        public int Compare(clsWork x, clsWork y)
        {
            

            return x.Date.CompareTo(y.Date);

            
        }
       // Step 1 singleton add
        private clsDateComparer()
        { }

        static clsDateComparer()
        { }

    }

}
