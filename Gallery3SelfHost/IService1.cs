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
        [OperationContract]
        int InsertArtist(clsArtist prArtist);
        [OperationContract]
        int UpdateArtist(clsArtist prArtist);

        //[OperationContract]
        //int InsertWork(clsWork prWork);
        //[OperationContract]
        //int UpdateWork(clsWork prWork);
        //[OperationContract]
        //int DeleteWork(clsWork prWork);


    }




}
