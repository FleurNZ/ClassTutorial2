using System;
using System.Collections.Generic;
using System.ServiceModel;
using SelfHost.DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gallery3SelfHost
{
    [ServiceContract]
    interface IService1
    {
     
        [OperationContract]
        List<string> GetArtistNames();
        [OperationContract]
        clsArtist GetArtist(string prArtistName);
        //clsArtist InsertArtist(clsArtist prArtist);
        //clsArtist UpdateArtist(clsArtist prArtist);



    }

   


}
