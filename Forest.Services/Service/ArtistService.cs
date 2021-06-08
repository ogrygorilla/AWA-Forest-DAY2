using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Data.Models.Domain;
using Forest.Data.DAO;
using Forest.Data.IDAO;
using Forest.Services.IService;
using Forest.Data.Repository;

namespace Forest.Services.Service
{
    public class ArtistService : IArtistService
    {
        private IArtistDAO artistDAO;

        public ArtistService()
        {
            artistDAO = new ArtistDAO();
        }
        public IList<Artist> GetArtists()
        {
            using (var context = new ForestContext())
            {
                return artistDAO.GetArtists(context);
            }
        }
    }
}
