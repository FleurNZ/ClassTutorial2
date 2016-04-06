namespace Version_2_C
{   
    //change to sealed class step 3 singleton
    sealed public partial class frmSculpture : Version_2_C.frmWork
    {
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

