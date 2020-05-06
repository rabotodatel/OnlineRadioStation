﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioStation
{
    interface IPlaylist
    {
        List<Composition> Playlist { get; }
        void Accept(IVisitor visitor, int bitrate);
    }
}
