using Forest.Data.IDAO;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.DAO
{
    public class GenreDAO : IGenreDAO
    {
        //private ForestContext context;
        //public GenreDAO()
        //{
        //    context = new ForestContext();
        //}
        public IList<Genre> GetGenres(ForestContext context)
        {
            return context.Genres.ToList();
        }

        public Genre GetGenre(int id, ForestContext context)
        {
            context.Genres.Include(g => g.Musics).ToList();
            // get genre with provided id
            Genre genre = context.Genres.Find(id);
            return genre;
        }

        public IList<Music> GetMusics(int id, ForestContext context)
        {
            context.Genres.Include(g => g.Musics).ToList();
            Genre genre = context.Genres.Find(id);
            return genre.Musics.ToList();
        }

        public void AddMusicToCollection(Music music, Genre genre, ForestContext context)
        {
            context.Genres.Find(genre.ID).Musics.Add(music);
        }
    }
}
