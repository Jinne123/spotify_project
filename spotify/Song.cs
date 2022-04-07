using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Song
    {
        private string title;
        public string Title
        {
            get { return this.title; }
        }
        private int duration;
        public int Duration
        {
            get { return this.duration; }
        }
        private string genre;
        public string Genre
        {
            get { return this.genre; }
        }
        private Artist artist;
        public Artist Artist
        {
            get { return this.artist; }
        }
        
        public Song(string title, int duration, string genre, Artist artist)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.genre = genre;
        }

        public override string ToString()
        {
            return this.title + " - " + this.artist.Name + " - " + this.duration + " - " + this.genre;
        }
    }
}
