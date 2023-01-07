using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicSearcher.BL.Models;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace MusicSearcher.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MusicSearcherController : ControllerBase
    {
        private readonly ILogger<MusicSearcherController> _logger;

        public MusicSearcherController(ILogger<MusicSearcherController> logger) 
        {
            _logger = logger;
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<string> GetArtists()
        {
            try
            {
                var artists = Artist.GetArtists().OrderBy(x => x.Id);

                // iterate through each artist
                foreach (var a in artists)
                {
                    Console.WriteLine("Id :" + a.Id + ", Name: " + a.ArtistName);
                }

                return Ok(JsonSerializer.Serialize(artists));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<string> GetAlbums()
        {
            try
            {
                var albums = Album.GetAlbums().OrderBy(x => x.AlbumArtist.Id);

                // iterate through each album
                foreach (var a in albums)
                {
                    Console.WriteLine("Id :" + a.Id + ", Album Name: " + a.AlbumName + ", Album Artist: " + a.AlbumArtist.ArtistName);
                }

                return Ok(JsonSerializer.Serialize(albums));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<string> FindAlbum(string albumName, string albumArtistName)
        {
            try
            {
                // gets list of albums
                var albums = Album.GetAlbums().OrderBy(x => x.AlbumArtist.Id);

                // return album when found, otherwise returns empty
                var result = albums.Where(x => x.AlbumArtist.ArtistName == albumArtistName &&
                                   x.AlbumName.Contains(albumName)).ToList();

                return Ok(JsonSerializer.Serialize(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
