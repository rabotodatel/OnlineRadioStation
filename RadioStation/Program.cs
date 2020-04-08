﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitrates = new StationsCollection();
            //var iterator = new StationIterator(frequencies);
            bitrates.AddBitrate(64);
            bitrates.AddBitrate(92);
            bitrates.AddBitrate(128);
            bitrates.AddBitrate(196);
            bitrates.AddBitrate(224);

            //bitrates.ReverseDirection();
            //foreach(var b in bitrates)
            //{
            //    Console.WriteLine(b);
            //}
            //Console.WriteLine("");

            //iterator.MoveNext();
            //iterator.MoveNext();
            //Console.WriteLine(iterator.Current());

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
            IEditPlaylist editSmallPlaylist = new EditPlaylist(smallPlaylist, song);
            editSmallPlaylist.AddComposition();
            IEditPlaylist editSmallPlaylist1 = new EditPlaylist(smallPlaylist, melody);
            editSmallPlaylist1.AddComposition();
            IEditPlaylist editLargePlaylist = new EditPlaylist(largePlaylist, theme);
            editLargePlaylist.AddComposition();
            IEditPlaylistAdvanced advanced = new EditPlaylistAdvanced(largePlaylist);
            IEditPlaylist editLargePlaylist1 = new AdvancedToEditPlaylist(advanced, smallPlaylist);
            editLargePlaylist1.AddComposition();
            
            foreach (Composition c in smallPlaylist.playlist)
            {
                Console.WriteLine(c.Name);
            }
            Console.WriteLine("");
            foreach (Composition c in largePlaylist.playlist)
            {
                Console.WriteLine(c.Name);
            }

            Console.ReadKey();
        }
    }
}