using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class SongViewModel
    {

        public string SongName { get; set; }

        public string Album { get; set; }

        public int? Rate { get; set; }

        public int? Duration { get; set; }

        public string Genre { get; set; }

        public string Group { get; set; }

        public string ArtistName { get; set; }

        public string ArtistSurname { get; set; }

        public SongViewModel(Song song, Artist artist)
        {
            SongName = song.Name;
            Album = song.Album;
            Rate = song.Rate;
            Duration = song.Duration;
            Genre = song.Genre;
            Group = artist.Group;
            ArtistName = artist.Name;
            ArtistSurname = artist.Surname;

        }
    }
}