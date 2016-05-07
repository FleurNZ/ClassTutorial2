using System;
using System.Runtime.Serialization;
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

        //[DataMember]
        //public ICollection<clsWork> Works { get; set; }

        //public clsArtist MapToEntity()
        //{
        //    //return new Artist()
        //    //{ Name = this.Name, Phone = this.Phone, Speciality = this.Speciality };
        //}
        }
       
}
