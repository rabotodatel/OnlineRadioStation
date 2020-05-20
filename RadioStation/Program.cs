using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RadioStationMiddleware;

namespace RadioStation
{
    class Program
    {
        static async Task<List<UserPlaylist>> GetPlaylistsAsync(string path)
        {
            List<UserPlaylist> playlists = null;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                playlists = JsonConvert.DeserializeObject<List<UserPlaylist>>(apiResponse);
            }
            return playlists;
        }

        static async void Display()
        {
            List<UserPlaylist> playlists = new List<UserPlaylist>();
            playlists = await GetPlaylistsAsync("https://localhost:44300/api/playlists");
            foreach (UserPlaylist p in playlists)
            {
                foreach (Composition c in p.Playlist)
                {
                    Console.WriteLine(c.Name);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Display();

            //var bitrates = new StationsCollection();
            //var iterator = new StationIterator(frequencies);

            //bitrates.ReverseDirection();
            //foreach(var b in bitrates)
            //{
            //    Console.WriteLine(b);
            //}
            //Console.WriteLine("");

            //iterator.MoveNext();
            //iterator.MoveNext();
            //Console.WriteLine(iterator.Current());

            //UserPlaylist smallPlaylist = new UserPlaylist();
            //UserPlaylist largePlaylist = new UserPlaylist();
            //Composition song = new Composition()
            //{
            //    Name = "song"
            //};
            //Composition theme = new Composition()
            //{
            //    Name = "theme"
            //};
            //Composition melody = new Composition()
            //{
            //    Name = "melody"
            //};

            //smallPlaylist.Playlist.Add(song);
            //smallPlaylist.Playlist.Add(theme);
            //largePlaylist.Playlist.Add(song);
            //largePlaylist.Playlist.Add(theme);
            //largePlaylist.Playlist.Add(melody);

            //IEditPlaylist editSmallPlaylist = new EditPlaylist(smallPlaylist, song);
            //editSmallPlaylist.AddComposition();
            //IEditPlaylist editSmallPlaylist1 = new EditPlaylist(smallPlaylist, melody);
            //editSmallPlaylist1.AddComposition();
            //IEditPlaylist editLargePlaylist = new EditPlaylist(largePlaylist, theme);
            //editLargePlaylist.AddComposition();
            //IEditPlaylistAdvanced advanced = new EditPlaylistAdvanced(largePlaylist);
            //IEditPlaylist editLargePlaylist1 = new AdvancedToEditPlaylist(advanced, smallPlaylist);
            //editLargePlaylist1.AddComposition();

            //foreach (Composition c in smallPlaylist.Playlist)
            //{
            //    Console.WriteLine(c.Name);
            //}
            //Console.WriteLine("");
            //foreach (Composition c in largePlaylist.Playlist)
            //{
            //    Console.WriteLine(c.Name);
            //}
            //Console.WriteLine("");

            //Facade facade = new Facade(largePlaylist, 92);
            //facade.Play();

            //var structure = new ObjectStructure();
            //structure.Add(smallPlaylist);
            //structure.Add(largePlaylist);
            //structure.Accept(new Player(), largePlaylist, 92);

            Console.ReadKey();
        }
    }
}
