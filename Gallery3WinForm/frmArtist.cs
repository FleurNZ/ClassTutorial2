using Gallery3WinForm.ServiceReference1;
using System;
//add generics reference
using System.Collections.Generic;
using System.Windows.Forms;



namespace Gallery3WinForm
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }


        private clsArtist _Artist;
        //private clsWorksList _WorksList;
        //instantiates a container that holds the contents of the dictionary step 1 of task 7.
        private static Dictionary<string, frmArtist> _ArtistFormList = new Dictionary<string, frmArtist>();

        //step 3 of task 7. Need to ask questions about this bit.
        public static void Run(string prArtistName)
        {
            frmArtist lcArtistForm;
            if (string.IsNullOrEmpty(prArtistName) || !_ArtistFormList.TryGetValue(prArtistName, out lcArtistForm))
            {
                lcArtistForm = new frmArtist();
                if (string.IsNullOrEmpty(prArtistName))

                    lcArtistForm.SetDetails(new clsArtist());

                else
                {
                    _ArtistFormList.Add(prArtistName, lcArtistForm);
                    lcArtistForm.refreshFormFromDB(prArtistName);
                }
            }
            else
            {
                lcArtistForm.Show();
                lcArtistForm.Activate();
            }

        }

        private void refreshFormFromDB(string prArtistName)
        {
            SetDetails(Program.SvcClient.GetArtist(prArtistName));
        }

        //task 9a tut 2
        private void updateTitle(string prArtistGalleryName)
        {
            if (!string.IsNullOrEmpty(prArtistGalleryName))
                Text = "Artist Details " + prArtistGalleryName;//shows ... when name is too long so no error when I though it was.
        }


        private void updateDisplay()
        {
            //maybe the right line to comment out step 11 of 7 tut 2.
            ////txtName.Enabled = txtName.Text == "";
            //if (_WorksList.SortOrder == 0)
            //{
            //    _WorksList.SortByName();
            //    rbByName.Checked = true;
            //}
            //else
            //{
            //    _WorksList.SortByDate();
            //    rbByDate.Checked = true;
            //}

            //lstWorks.DataSource = null;
            //lstWorks.DataSource = _WorksList;
            //lblTotal.Text = Convert.ToString(_WorksList.GetTotalValue());
        }

        public void SetDetails(clsArtist prArtist)
        {
            _Artist = prArtist;//Name
            //line added step 11 of 7 tut 2
            txtName.Enabled = string.IsNullOrEmpty(_Artist.Name);
            updateForm();
            updateDisplay();
            //method changed for step 4 of 7 tut 2.
            Show();
            //task 9b tut 2
            frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
        }

        private void updateForm()
        {
            
            txtName.Text = _Artist.Name;
            txtSpeciality.Text = _Artist.Speciality;
            txtPhone.Text = _Artist.Phone;
            //_WorksList = _Artist.WorksList;
            //testing added this call hear seems to work.
            //frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
        }

        private void pushData()
        {
            
            _Artist.Name = txtName.Text;
            _Artist.Speciality = txtSpeciality.Text;
            _Artist.Phone = txtPhone.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstWorks.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //_WorksList.RemoveAt(lcIndex);
                //added step 13 task 7 tut 2.
                frmMain.Instance.UpdateDisplay();
                updateDisplay();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string lcReply = new InputBox(clsWork.FACTORY_PROMPT).Answer;
            //if (!string.IsNullOrEmpty(lcReply))
            //{
            //    _WorksList.AddWork(lcReply[0]);
            //    //added step 13 task 7 tut 2.
            //    frmMain.Instance.UpdateDisplay();
            //    updateDisplay();
            //}
        }

        //more code added to make btn intelligent step 9 or 7 tut 2.
        private void btnClose_Click(object sender, EventArgs e)
        {
          
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtName.Enabled)
                    {
                        //Program.SvcClient.InsertArtist(_Artist);
                        MessageBox.Show("Artist added!", "Sucess");
                        frmMain.Instance.UpdateDisplay();
                        txtName.Enabled = false;
                    }
                    else
                        //Program.SvcClient.UpdateArtist(_Artist);
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private Boolean isValid()
        {
            //if (txtName.Enabled && txtName.Text != "")
            //    if (_Artist.IsDuplicate(txtName.Text))
            //    {
            //        MessageBox.Show("Artist with that name already exists!", "Error adding artist");
            //        return false;
            //    }
            //    else
            //        return true;
            //else
                return true;
        }

        private void lstWorks_DoubleClick(object sender, EventArgs e)
        {
            try
            {
               // _WorksList.EditWork(lstWorks.SelectedIndex);
                //added step 13 task 7 tut 2.
                frmMain.Instance.UpdateDisplay();
                updateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
           // _WorksList.SortOrder = Convert.ToByte(rbByDate.Checked);
            updateDisplay();
        }
    }
}