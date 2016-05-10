using System;
using System.Windows.Forms;
using Gallery3WinForm.ServiceReference1;

namespace Gallery3WinForm
{

    //changed class to sealed
    public sealed partial class frmMain : Form
    {
        //task 8b tut 2
        public delegate void Notify(string prGalleryName);
        //task 8c tut 2
        public event Notify GalleryNameChanged;

        //singleton frm main a bit different  you need to encapsulate field to get a public variable this is due to the optimiser.
        private static readonly frmMain _Instance = new frmMain();

        //should change class to private for singleton but seems to error on this one??
        private frmMain()
        {
            InitializeComponent();

        }



        //private clsArtistList _ArtistList = new clsArtistList();



        public static frmMain Instance
        {
            get
            {

                return _Instance;

            }

        }

        //task 8D tut 2
        private void updateTitle(string prGalleryName)
        {
            if (!string.IsNullOrEmpty(prGalleryName))
                Text = "Gallery - " + prGalleryName;
        }


        //step 10 of 7 in tut 2 private becomes public
        public void UpdateDisplay()
        {
            lstArtists.DataSource = null;
            lstArtists.DataSource = Program.SvcClient.GetArtistNames();
            //if (_ArtistList == null)
            //{
            //    //testing to see what happens this could be improved
            //    lstArtists.DataSource = null;
            //    //string[] lcDisplayList = new string[_ArtistList.Count];
            //    //_ArtistList.Keys.CopyTo(lcDisplayList, 0);
            //    //lstArtists.DataSource = lcDisplayList;
            //    //lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
            //}

            ////else
            ////{
            //string[] lcDisplayList = new string[_ArtistList.Count];
            //_ArtistList.Keys.CopyTo(lcDisplayList, 0);
            //lstArtists.DataSource = lcDisplayList;
            //lblValue.Text = Convert.ToString(_ArtistList.GetTotalValue());
            ////}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                frmArtist.Run(null);
                //_ArtistList.NewArtist();
                MessageBox.Show("Artist added!", "Success");
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new artist");
            }
        }

        private void lstArtists_DoubleClick(object sender, EventArgs e)
        {
            //string lcKey;

            //lcKey = Convert.ToString(lstArtists.SelectedItem);
            //if (lcKey != null)
            //    try
            //    {
                    //Step 6 of task 7
                    frmArtist.Run(lstArtists.SelectedItem as string);
                    //_ArtistList.EditArtist(lcKey);
                    //updateDisplay();
                    //trying this out
                    // updateTitle(string prGalleryName);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "This should never occur");
                //}
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    _ArtistList.Save();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "File Save Error");
            //}
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting artist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    clsArtist lcArtist = new clsArtist() { Name = lcKey };
                    Program.SvcClient.DeleteArtist(lcArtist);
                    //_ArtistList.Remove(lcKey);
                    lstArtists.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting artist");
                }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    _ArtistList = clsArtistList.RetrieveArtistList();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "File retrieve error");
            //}
            UpdateDisplay();
            //task 8E tut 2
            //GalleryNameChanged += new Notify(updateTitle);
            //GalleryNameChanged(_ArtistList.GalleryName);//event raising
        }



      
        //task 8f tut 2
        private void GalName_Click(object sender, EventArgs e)
        {
            //string lcReply = new InputBox("Set a new gallery Name - Currently: " + _ArtistList.GalleryName).Answer;
            //if (!string.IsNullOrEmpty(lcReply))
            //{
            //    _ArtistList.GalleryName = lcReply;
            //    GalleryNameChanged(lcReply);
            //}
        }
    }
}