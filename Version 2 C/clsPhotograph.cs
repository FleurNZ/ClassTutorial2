using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsPhotograph : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;

        //step one creating a delegate for observer pattern 2 lines.
        public delegate void LoadPhotographFormDelegate(clsPhotograph prPhotograph);
        public static LoadPhotographFormDelegate LoadPhotographForm;

        //commented this out not sure if right for step 4 singleton
        //[NonSerialized()]
        //private frmPhotograph _PhotoDialog;

        public override void EditDetails()
        {
            //step 2 added to call delegate for observer pattern replaces the code added for singleton.
            LoadPhotographForm(this);
            //where ever there is new used you will get an error once converted to singleton so you need to correct.
            //singleton does not need this code change check what I have done with Matthias
            //step 5 singleton one line of code
            //frmPhotograph.Instance.SetDetails(this);

            //if (_PhotoDialog == null)
            //    _PhotoDialog = new frmPhotograph();
            //_PhotoDialog.SetDetails(this);
        }

        public Single Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public Single Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
