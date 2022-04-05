using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Album
    {
        public string Description;
        public string Title;
        public string Genre;
        public string ReleaseDate;
        public Artist artist;

        public Album(string title, string genre, string releaseDate, string description, Artist artist)
        {
            this.artist = artist;
            this.Title = title;
            this.Genre = genre;
            this.ReleaseDate = releaseDate;
            this.Description = description;
        }

        /* public Album(string title, string artist, string genre, string releaseDate, string description)
         {
             Title = title;
             Artist = artist;
             Genre = genre;
             ReleaseDate = releaseDate;
             Description = description;
         }*/
    }
}
