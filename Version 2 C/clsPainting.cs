using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsPainting : clsWork
    {
        private float _Width;
        private float _Height;
        private string _Type;
        //step one creating a delegate for observer pattern 2 lines.
        public delegate void LoadPaintingFormDelegate(clsPainting prPainting);
        public static LoadPaintingFormDelegate LoadPaintingForm;

        //commented this out not sure if right for step 4 singleton
        //[NonSerialized()]
       // private static frmPainting _PaintDialog;
       //observer says to do this at step 5 too but I did in singleton change and everythingw worked still??

        public override void EditDetails()
        {
            //step 2 added to call delegate for observer pattern replaces the code added for singleton.
            LoadPaintingForm(this);

            //where ever there is new used you will get an error once converted to singleton so you need to correct.
            //singleton does not need this code change check what I have done with Matthias
            //commented this out not sure if right for step 5 singleton
            //frmPainting.Instance.SetDetails(this);

            //if (_PaintDialog == null)
            //_PaintDialog = new frmPainting();
            //_PaintDialog.SetDetails(this);


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
