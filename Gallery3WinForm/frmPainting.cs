using Gallery3WinForm.ServiceReference1;

namespace Gally3WinForm
{
    //change to sealed class step 3 singleton
    sealed public partial class frmPainting : Gally3WinForm.frmWork
    {
        //step 3 added for observer pattern
        public static void Run(clsPainting prPainting)
        {
            //this line of code is now calling on the instance implemented for the singleton pattern
            Instance.SetDetails(prPainting);
        }

        //added for singleton step 2 in this case I made this public is this right??
        public static readonly frmPainting Instance = new frmPainting();
        //change public class to private class singleton step 1
        private frmPainting()
        {
            InitializeComponent();
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsPainting lcWork = (clsPainting)_Work;
            txtWidth.Text = lcWork.Width.ToString();
            txtHeight.Text = lcWork.Height.ToString();
            txtType.Text = lcWork.Type;
        }

        protected override void pushData()
        {
            base.pushData();
            clsPainting lcWork = (clsPainting)_Work;
            lcWork.Width = float.Parse(txtWidth.Text);
            lcWork.Height = float.Parse(txtHeight.Text);
            lcWork.Type = txtType.Text;
        }

    }
}

