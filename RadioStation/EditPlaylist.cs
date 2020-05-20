using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStationMiddleware
{
    class EditPlaylist:IEditPlaylist
    {
        private UserPlaylist _userPlaylist = new UserPlaylist();
        private Composition _composition;
        public EditPlaylist() { }
        public EditPlaylist(UserPlaylist userPlaylist, Composition composition)
        {
            _userPlaylist = userPlaylist;
            _composition = composition;
        }
        public void AddComposition()
        {
            _userPlaylist?.Playlist?.Add(_composition);
        }
        public void RemoveComposition()
        {
            foreach (Composition c in _userPlaylist.Playlist)
            {
                if(c == _composition)
                {
                    _userPlaylist?.Playlist?.Remove(_composition);
                    return;
                }
            }
        }
    }
}
