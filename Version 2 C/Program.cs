using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Version_2_C
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // below line added for observer pattern step 4
            clsPainting.LoadPaintingForm = new clsPainting.LoadPaintingFormDelegate(frmPainting.Run);
            Application.Run(new frmMain());//this line has errors when singleton first implemented until fix is carried out.
        }


    }
}
