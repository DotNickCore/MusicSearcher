using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSearcher.BL.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public Artist AlbumArtist { get; set; }

        public static List<Album> GetAlbums()
        {
            return new List<Album>()
            {
                new Album()
                {
                    Id = 2001,
                    AlbumName = "Core",
                    AlbumArtist = new Artist()
                    {
                        Id = 1002,
                        ArtistName = "Stone Temple Pilots"
                    }
                },
                new Album()
                {
                    Id = 2002,
                    AlbumName = "Purple",
                    AlbumArtist = new Artist()
                    {
                        Id = 1002,
                        ArtistName = "Stone Temple Pilots"
                    }
                },
                new Album()
                {
                    Id = 2003,
                    AlbumName = "Tiny Music... Songs from the Vatican Gift Shop",
                    AlbumArtist = new Artist()
                    {
                        Id = 1002,
                        ArtistName = "Stone Temple Pilots"
                    }
                },
                new Album()
                {
                    Id = 2004,
                    AlbumName = "No. 4",
                    AlbumArtist = new Artist()
                    {
                        Id = 1002,
                        ArtistName = "Stone Temple Pilots"
                    }
                },
                new Album()
                {
                    Id = 2005,
                    AlbumName = "Shangri-La Dee Da",
                    AlbumArtist = new Artist()
                    {
                        Id = 1002,
                        ArtistName = "Stone Temple Pilots"
                    }
                },
                new Album()
                {
                    Id = 2006,
                    AlbumName = "Queen",
                    AlbumArtist = new Artist()
                    {
                        Id = 1001,
                        ArtistName = "Queen"
                    }
                },
                new Album()
                {
                    Id = 2007,
                    AlbumName = "Queen II",
                    AlbumArtist = new Artist()
                    {
                        Id = 1001,
                        ArtistName = "Queen"
                    }
                },
                new Album()
                {
                    Id = 2008,
                    AlbumName = "Sheer Heart Attack",
                    AlbumArtist = new Artist()
                    {
                        Id = 1001,
                        ArtistName = "Queen"
                    }
                },
                new Album()
                {
                    Id = 2009,
                    AlbumName = "A Night At The Opera",
                    AlbumArtist = new Artist()
                    {
                        Id = 1001,
                        ArtistName = "Queen"
                    }
                },
                new Album()
                {
                    Id = 2010,
                    AlbumName = "A Day At The Races",
                    AlbumArtist = new Artist()
                    {
                        Id = 1001,
                        ArtistName = "Queen"
                    }
                },
                new Album()
                {
                    Id = 2011,
                    AlbumName = "Foo Fighters",
                    AlbumArtist = new Artist()
                    {
                        Id = 1003,
                        ArtistName = "Foo Fighters"
                    }
                },
                new Album()
                {
                    Id = 2012,
                    AlbumName = "The Colour and the Shape",
                    AlbumArtist = new Artist()
                    {
                        Id = 1003,
                        ArtistName = "Foo Fighters"
                    }
                },
                new Album()
                {
                    Id = 2013,
                    AlbumName = "There Is Nothing Left to Lose",
                    AlbumArtist = new Artist()
                    {
                        Id = 1003,
                        ArtistName = "Foo Fighters"
                    }
                },
                new Album()
                {
                    Id = 2014,
                    AlbumName = "One By One",
                    AlbumArtist = new Artist()
                    {
                        Id = 1003,
                        ArtistName = "Foo Fighters"
                    }
                },
                new Album()
                {
                    Id = 2015,
                    AlbumName = "In Your Honor",
                    AlbumArtist = new Artist()
                    {
                        Id = 1003,
                        ArtistName = "Foo Fighters"
                    }
                }
            };
        }
    }
}
