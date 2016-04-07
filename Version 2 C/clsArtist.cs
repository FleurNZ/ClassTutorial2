using System;
using System.Collections.Generic;

namespace Version_2_C
{
    [Serializable()]
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;

        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        //removed for step 7 of task 7 of tut 2.
        //private static frmArtist _ArtistDialog = new frmArtist();

        public clsArtist() { }

        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList();
            _ArtistList = prArtistList;
            //removed for step 7 of task 7 of tut 2.
            // EditDetails();
        }

        //moved from clsArtsitList step 8 of 7 tut 2 and modified.
        public void NewArtist()
        {
            if (!string.IsNullOrEmpty(Name))
                _ArtistList.Add(Name, this);
            else
                throw new Exception("no artist name entered");
            //clsArtist lcArtist = new clsArtist(this);
            //if (lcArtist.Name != "")
            //    Add(lcArtist.Name, lcArtist);
        }

        //obsolete after step 7 in task 7 tut 2.
        //public void EditDetails()
        //{
        //    _ArtistDialog.SetDetails(this);
        //    _TotalValue = _WorksList.GetTotalValue();
        //}

        public bool IsDuplicate(string prArtistName)
        {
            return _ArtistList.ContainsKey(prArtistName);
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Speciality
        {
            get { return _Speciality; }
            set { _Speciality = value; }
        }

        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        public decimal TotalValue
        {
            //step 12 task 7 tut 2
            get { return _WorksList.GetTotalValue(); }
            //get { return _TotalValue; }
        }

        public clsWorksList WorksList
        {
            get { return _WorksList; }
        }
    }
}
