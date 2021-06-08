using Forest.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Data.Repository;

namespace Forest.Data.IDAO
{
    public interface IGenreDAO
    {
        IList<Genre> GetGenres(ForestContext context);

        Genre GetGenre(int id, ForestContext context);

        IList<Music> GetMusics(int id, ForestContext context);

        void AddMusicToCollection(Music music, Genre genre, ForestContext context);
    }
}
