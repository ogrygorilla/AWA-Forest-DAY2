using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Data.Models.Domain;
using Forest.Data.Repository;

namespace Forest.Data.IDAO
{
    public interface IArtistDAO
    {
        IList<Artist> GetArtists(ForestContext context);
        Artist GetArtist(int id, ForestContext context);
        void AddMusicToCollection(Music music, Artist artist, ForestContext context);
    }
}
