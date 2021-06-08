using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.Models.Domain
{
    public class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Music> Musics { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
