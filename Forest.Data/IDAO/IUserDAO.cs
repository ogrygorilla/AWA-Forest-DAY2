using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Forest.Data.Models.Domain;
using Forest.Data.Repository;


namespace Forest.Data.IDAO
{
    public interface IUserDAO
    {
        void AddMusicToCollection(Music music, string userId, ForestContext context);
    }
}
