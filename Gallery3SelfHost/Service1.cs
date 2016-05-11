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
                { Name = lcArtist.Name, Speciality = lcArtist.Speciality, Phone = lcArtist.Phone, Works = new List<clsWork>() };
                foreach (Work item in lcArtist.Works)
                    lcArtistDTO.Works.Add(item.MapToDTO());
                return lcArtistDTO;
                //{ Name = lcArtist.Name, Speciality = lcArtist.Speciality, Phone = lcArtist.Phone };
                //return lcArtistDTO;

            }
        }

        private int process<TEntity>(TEntity prItem, System.Data.Entity.EntityState prState) where TEntity : class
        {
            try
            {
                using (Gallery_DataEntities lcContext = new Gallery_DataEntities())
                {
                    lcContext.Entry(prItem).State = prState;
                    int lcCount = lcContext.SaveChanges();
                    return lcCount;

                }
            }
            catch (Exception ex)
            {
                //another option is throw ex.GetBaseException(); with the app config modification.
                Console.WriteLine(ex.GetBaseException().Message);
                return 0; //looking for int.
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

        public int DeleteArtist(clsArtist prArtist)
        {
            return process(prArtist.MapToEntity(), System.Data.Entity.EntityState.Deleted);
        }

        public int UpdateWork(clsWork prWork)
        {
            return process(prWork.MapToEntity(), System.Data.Entity.EntityState.Modified);
        }

        public int InsertWork(clsWork prWork)
        {
            return process(prWork.MapToEntity(), System.Data.Entity.EntityState.Added);
        }

        public int DeleteWork(clsWork prWork)
        {
            return process(prWork.MapToEntity(), System.Data.Entity.EntityState.Deleted);
        }
    }
    ///app config can changed exception details value to true to find out more information about exception if using console debug is not an option.
}

