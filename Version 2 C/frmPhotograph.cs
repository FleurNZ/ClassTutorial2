namespace Version_2_C
{
    //step 3 change to sealed class for singleton
    sealed public partial class frmPhotograph : Version_2_C.frmWork
    {
        //step 3 added for observer pattern
        public static void Run(clsPhotograph prPhotograph)
        {
            //this line of code is now calling on the instance implemented for the singleton pattern
            Instance.SetDetails(prPhotograph);
        }

        //added for singleton step 2 in this case I made this public is this right??
        public static readonly frmPhotograph Instance = new frmPhotograph();
        //change to private class for singleton step 1
        private frmPhotograph()
        {
            InitializeComponent();
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsPhotograph lcWork = (clsPhotograph)this._Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            clsPhotograph lcWork = (clsPhotograph)_Work;
            lcWork.Width = float.Parse(txtWidth.Text);
            lcWork.Height = float.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }
    }
}

