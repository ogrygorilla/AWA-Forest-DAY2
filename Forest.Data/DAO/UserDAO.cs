using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.Models.Domain;
using Forest.Data.Repository;
using System.Data.Entity;
using Forest.Data.IDAO;

namespace Forest.Data.DAO
{
    public class UserDAO : IUserDAO
    {
        public void AddMusicToCollection(Music music, string userId, ForestContext context)
        {
            context.Users.Find(userId).Musics.Add(music);
        }
    }
}
