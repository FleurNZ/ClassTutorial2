using System;
using System.Windows.Forms;
using Gallery3WinForm.ServiceReference1;
using Gallery3WinForm;

namespace Gally3WinForm
{
    public partial class frmWork : Form
    {
        protected clsWork _Work;

        public frmWork()
        {
            InitializeComponent();
        }

        public void SetDetails(clsWork prWork)
        {
            _Work = prWork;
            updateForm();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                try
                {
                    if (txtName.Enabled)
                    {
                        Program.SvcClient.InsertWork(_Work);
                    }
                    else
                    { Program.SvcClient.UpdateWork(_Work); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "item can not be saved or updated");
                }

                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtName.Enabled = string.IsNullOrEmpty(_Work.Name);
            txtName.Text = _Work.Name;
            txtCreation.Text = _Work.Date.ToShortDateString();
            txtValue.Text = _Work.Value.ToString();
        }

        protected virtual void pushData()
        {
            _Work.Name = txtName.Text;
            _Work.Date = DateTime.Parse(txtCreation.Text);
            _Work.Value = decimal.Parse(txtValue.Text);
        }

    }
}