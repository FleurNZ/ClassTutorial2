using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3WinForm.ServiceReference1
{
    public abstract partial class clsWork
    {

        private string _Name;
        private DateTime _Date = DateTime.Now;

        public override string ToString()
        {
            return _Name + "\t" + _Date.ToShortDateString();
        }

        public abstract void EditDetails();
    }

    public partial class clsPainting
    {
        public delegate void LoadPaintingFormDelegate(clsPainting prPainting);
        public static LoadPaintingFormDelegate LoadPaintingForm;
        public override void EditDetails()
        {
            LoadPaintingForm(this);
        }
    }

    public partial class clsPhotograph
    {
        public delegate void LoadPhotographFormDelegate(clsPhotograph prPhotograph);
        public static LoadPhotographFormDelegate LoadPhotographForm;

        public override void EditDetails()
        {
            LoadPhotographForm(this);
        }
    }

    public partial class clsSculpture : clsWork
    {
        public delegate void LoadSculptureFormDelegate(clsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;
        public override void EditDetails()
        {
            LoadSculptureForm(this);
        }
    }
}
