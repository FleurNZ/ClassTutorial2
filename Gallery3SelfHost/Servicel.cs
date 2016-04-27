﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3SelfHost
{   //add : IService1
    class Service1:IService1
    {
        public List<string> GetArtistNames()
        {
            using (Gallery_DataEntities lcContext = new Gallery_DataEntities())
                return lcContext.Artists
                        .Select(lcArtists => lcArtists.Name)
                        .ToList();
        }
    }
}
