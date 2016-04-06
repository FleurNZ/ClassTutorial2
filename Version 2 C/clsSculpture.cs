using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsSculpture : clsWork
    {
        private float _Weight;
        private string _Material;
        //commented this out not sure if right for step 4 singleton
        //[NonSerialized()]
        //private static frmSculpture _SculptureDialog;

        public override void EditDetails()
        {
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
