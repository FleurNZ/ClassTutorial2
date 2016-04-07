using System;
using System.Windows.Forms;

namespace Version_2_C
{
  
    //changed class to sealed
   public sealed partial class frmMain : Form
    {
        //singleton frm main a bit different  you need to encapsulate field to get a public variable this is due to the optimiser.
        private static readonly frmMain _Instance = new frmMain();
        
        //should change class to private for singleton but seems to error on this one??
        private frmMain()
        {
            InitializeComponent();
           
        }

       

        private clsArtistList _ArtistList = new clsArtistList();



        public static frmMain Instance
        {
            get
            {

                return _Instance;

            }

        }

        //step 10 of 7 in tut 2 private becomes public
        public void UpdateDisplay()
        {
            if (_ArtistList == null)
            {
                //testing to see what happens this could be improved
                lstArtists.DataSource = null;
                //string[] lcDisplayList = new string[_ArtistList.Count];
                //_ArtistList.Keys.CopyTo(lcDisplayList, 0);
                //lstArtists.DataSource = lcDisplayList;
                //lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
            }

            //else
            //{
                string[] lcDisplayList = new string[_ArtistList.Count];
                _ArtistList.Keys.CopyTo(lcDisplayList, 0);
                lstArtists.DataSource = lcDisplayList;
                lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //step 6 task 7
                frmArtist.Run(new clsArtist(_ArtistList));
                //_ArtistList.NewArtist();
                //MessageBox.Show("Artist added!", "Success");
                //updateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new artist");
            }
        }

        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
                try
                {
                    //Step 6 of task 7
                    frmArtist.Run(_ArtistList[lcKey]);
                    //_ArtistList.EditArtist(lcKey);
                    //updateDisplay();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            try
            {
                _ArtistList.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Save Error");
            }
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting artist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    _ArtistList.Remove(lcKey);
                    lstArtists.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleing artist");
                }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                _ArtistList = clsArtistList.RetrieveArtistList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File retrieve error");
            }
            UpdateDisplay();
        }
    }
}