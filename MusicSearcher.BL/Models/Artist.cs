using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSearcher.BL.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }

        public static List<Artist> GetArtists()
        {
            return new List<Artist>()
            {
                new Artist
                {
                    Id = 1001,
                    ArtistName = "Queen"
                },
                new Artist
                {
                    Id = 1002,
                    ArtistName = "Stone Temple Pilots"
                },
                new Artist
                {
                    Id = 1003,
                    ArtistName = "Foo Fighters"
                }
            };
        }
    }
}
