using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class ObjectStructure
    {
        private List<IPlaylist> _playlists = new List<IPlaylist>();
        public void Add(IPlaylist playlist)
        {
            _playlists.Add(playlist);
        }
        public void Remove(IPlaylist playlist)
        {
            if(_playlists.Contains(playlist))
            {
                _playlists.Remove(playlist);
            }
        }
        public void Clear()
        {
            _playlists.Clear();
        }
        public void Accept(IVisitor visitor, IPlaylist playlist, int bitrate)
        {
            playlist.Accept(visitor, bitrate);
        }
    }
}
