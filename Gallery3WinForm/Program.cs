using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gallery3WinForm.ServiceReference1;
using Gally3WinForm;

namespace Gallery3WinForm
{
    static class Program
    {
        //Just need to work on adding cascade delete and checking other bits that can be corrected and improved.
        public static ServiceReference1.Service1Client SvcClient = new ServiceReference1.Service1Client();

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
            clsPhotograph.LoadPhotographForm = new clsPhotograph.LoadPhotographFormDelegate(frmPhotograph.Run);
            clsSculpture.LoadSculptureForm = new clsSculpture.LoadSculptureFormDelegate(frmSculpture.Run);

            //Application.Run(new frmMain());//this line has errors when singleton first implemented until fix is carried out.
            Application.Run(frmMain.Instance);
            //tidy up after using service
            if (SvcClient != null && SvcClient.State != System.ServiceModel.CommunicationState.Closed)
                SvcClient.Close();



        }
    }
}
