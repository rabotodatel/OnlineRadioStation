using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RadioStationMiddleware;

namespace RadioStationServer
{
    public class PlaylistsHolder
    {
        public List<IPlaylist> playlists;
        private static PlaylistsHolder instance;
        private PlaylistsHolder()
        {
            playlists = new List<IPlaylist>();
            var bitrates = new StationsCollection();
            UserPlaylist smallPlaylist = new UserPlaylist();
            UserPlaylist largePlaylist = new UserPlaylist();
            Composition song = new Composition()
            {
                Name = "song"
            };
            Composition theme = new Composition()
            {
                Name = "theme"
            };
            Composition melody = new Composition()
            {
                Name = "melody"
            };

            smallPlaylist.Playlist.Add(song);
            smallPlaylist.Playlist.Add(theme);
            largePlaylist.Playlist.Add(song);
            largePlaylist.Playlist.Add(theme);
            largePlaylist.Playlist.Add(melody);



            playlists.Add(smallPlaylist);
            playlists.Add(largePlaylist);
        }
        public static PlaylistsHolder GetInstance()
        {
            if (instance == null)
            {
                instance = new PlaylistsHolder();
            }
            return instance;
        }
    }
}
