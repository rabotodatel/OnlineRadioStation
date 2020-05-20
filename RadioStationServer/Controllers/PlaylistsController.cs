using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RadioStationMiddleware;

namespace RadioStationServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<IPlaylist>> Get()
        {
            PlaylistsHolder playlistsHolder = PlaylistsHolder.GetInstance();
            return playlistsHolder.playlists;
        }
    }
}