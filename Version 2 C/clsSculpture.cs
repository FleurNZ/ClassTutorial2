using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;

        //step one creating a delegate for observer pattern 2 lines.
        public delegate void LoadSculptureFormDelegate(clsSculpture prSculpture);
        public static LoadSculptureFormDelegate LoadSculptureForm;

        //commented this out not sure if right for step 4 singleton
        //[NonSerialized()]
        //private static frmSculpture _SculptureDialog;

        public override void EditDetails()
        {
            //step 2 added to call delegate for observer pattern replaces the code added for singleton.
            LoadSculptureForm(this);
            //where ever there is new used you will get an error once converted to singleton so you need to correct.
            //singleton does not need this code change check what I have done with Matthias
            //commented this out not sure if right for step 5 singleton
            frmSculpture.Instance.SetDetails(this);
            //if (_SculptureDialog == null)
            //_SculptureDialog = new frmSculpture();
            //_SculptureDialog.SetDetails(this);
        }

        public Single Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Material
        {
            get { return _Material; }
            set { _Material = value; }
        }
    }
}
