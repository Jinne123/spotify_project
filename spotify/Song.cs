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
        private string artist;
        public string Artist
        {
            get { return this.artist; }
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

        public Song(string title, string artist, int duration, string genre)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.genre = genre;
        }
        
    }
}
