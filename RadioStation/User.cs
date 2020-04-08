using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<UserPlaylist> playlists = new List<UserPlaylist>();
    }
}
