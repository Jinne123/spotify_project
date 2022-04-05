using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public string genre;

        public Song(string title, string artist, int duration, string genre)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.genre = genre;
        }
        
    }
}
