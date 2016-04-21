using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gallery3SelfHost
{
    [ServiceContract]
    interface IServicel
    {
     
        [OperationContract]
        List<string> GetArtistNames();
        

    }

   


}
