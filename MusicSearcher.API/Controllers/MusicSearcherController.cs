using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicSearcher.BL.Models;
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
    }
}
