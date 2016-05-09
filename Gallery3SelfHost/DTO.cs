using System;
using System.Runtime.Serialization;
using Gallery3SelfHost;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost.DTO
{
    [DataContract]
    public class clsArtist
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Speciality { get; set; }
        [DataMember]
        public string Phone { get; set; }

        [DataMember]//what about virtual
        public virtual ICollection<clsWork> Works { get; set; }

        public Artist MapToEntity()
        {
            return new Artist()
            { Name = this.Name, Phone = this.Phone, Speciality = this.Speciality };
        }
    }

        [DataContract]
        [KnownType(typeof(clsPhotograph))]
        [KnownType(typeof(clsPainting))]
        [KnownType(typeof(clsSculpture))]
        public abstract class clsWork
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public System.DateTime Date { get; set; }
            [DataMember]
            public decimal Value { get; set; }
            [DataMember]
            public string ArtistName { get; set; }
        }

        [DataContract]
        public class clsPhotograph : clsWork
        {
            [DataMember]
            public Nullable<float> Width { get; set; } //set as Single in properties of GalleryModel
            [DataMember]
            public Nullable<float> Height { get; set; } // set as Single
            [DataMember]
            public string Type { get; set; }
        }

        [DataContract]
        public class clsPainting : clsWork
        {
            [DataMember]
            public Nullable<float> Width { get; set; }
            [DataMember]
            public Nullable<float> Height { get; set; }
            [DataMember]
            public string Type { get; set; }
        }

        [DataContract]
        public class clsSculpture : clsWork
        {
            [DataMember]
            public Nullable<float> Weight { get; set; }
            [DataMember]
            public string Material { get; set; }
        }    
       
}
