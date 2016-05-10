using Gallery3WinForm.ServiceReference1;

namespace Gally3WinForm
{   
    //change to sealed class step 3 singleton
    sealed public partial class frmSculpture : Gally3WinForm.frmWork
    {

        //step 3 added for observer pattern
        public static void Run(clsSculpture prSculpture)
        {
            //this line of code is now calling on the instance implemented for the singleton pattern
            Instance.SetDetails(prSculpture);
        }
        //added for singleton step 2 in this case I made this public is this right??
        public static readonly frmSculpture Instance = new frmSculpture();
        //change public class to private class singleton step 1
        private frmSculpture()
        {
            InitializeComponent();
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsSculpture lcWork = (clsSculpture)this._Work;
            txtWeight.Text = lcWork.Weight.ToString();
            txtMaterial.Text = lcWork.Material;
        }

        protected override void pushData()
        {
            base.pushData();
            clsSculpture lcWork = (clsSculpture)_Work;
            lcWork.Weight = float.Parse(txtWeight.Text);
            lcWork.Material = txtMaterial.Text;
        }
    }
}

