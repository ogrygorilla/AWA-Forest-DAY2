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
    public class GenreService : IGenreService
    {
        private IGenreDAO genreDAO;

        public GenreService()
        {
            genreDAO = new GenreDAO();
        }

        public IList<Genre> GetGenres()
        {
            using (var context = new ForestContext())
            {
                return genreDAO.GetGenres(context);
            }
        }

        public Genre GetGenre(int id)
        {
            using (var context = new ForestContext())
            {
                //get genre dependet on privided id
                Genre genre = genreDAO.GetGenre(id, context);
                return genre;
            }
            
        }

        public IList<Music> GetMusics(int id)
        {
            using (var context = new ForestContext())
            {
                IList<Music> musics = genreDAO.GetMusics(id, context);
                return musics;
            }
            
        }
    }
}
