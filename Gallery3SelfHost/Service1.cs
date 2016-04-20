using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3SelfHost
{
    class Service1
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
