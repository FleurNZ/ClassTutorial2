using System;
using System.Collections.Generic;
using System.Linq;
using SelfHost.DTO;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Gallery3SelfHost
{
    class Service1 : IService1
    {
        public List<string> GetArtistNames()
        {
            using (Gallery_DataEntities lcContext = new Gallery_DataEntities())
                return lcContext.Artists
                        .Select(lcArtists => lcArtists.Name)
                        .ToList();
        }

        public clsArtist GetArtist(string prArtistName)
        {
            using (Gallery_DataEntities lcContext = new Gallery_DataEntities())
            {
                Artist lcArtist = lcContext.Artists
                     .Include("Works")
                     .Where(Artist => Artist.Name == prArtistName)
                     .FirstOrDefault();
                clsArtist lcArtistDTO = new clsArtist
                //{ Name = lcArtist.Name, Speciality = lcArtist.Speciality, Phone = lcArtist.Phone, Works = new List<clsWork>() };
                //foreach (Work item in lcArtist.Works)
                //    lcArtistDTO.Works.Add(item.MapToDTO());
                //return lcArtistDTO;
                { Name = lcArtist.Name, Speciality = lcArtist.Speciality, Phone = lcArtist.Phone };
                return lcArtistDTO;

            }
        }

        private int process<TEntity>(TEntity prItem, System.Data.Entity.EntityState prState) where TEntity : class
        {
            using (Gallery_DataEntities lcContext = new Gallery_DataEntities())
            {
                lcContext.Entry(prItem).State = prState;
                int lcCount = lcContext.SaveChanges();
                return lcCount;

            }
        }

        public int UpdateArtist(clsArtist prArtist)
        {
            return process(prArtist.MapToEntity(), System.Data.Entity.EntityState.Modified);
        }

        public int InsertArtist(clsArtist prArtist)
        {
            return process(prArtist.MapToEntity(), System.Data.Entity.EntityState.Added);
        }
    }
}

