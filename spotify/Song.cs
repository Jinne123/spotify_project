using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Song : Iplayable
    {
        private string title { get; set; }
        private int duration { get; set; }
        private Artist artist { get; set; }
        private string genre { get; set; }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setDuration(int duration)
        {
            this.duration = duration;
        }
        public void setArtist(Artist artist)
        {
            this.artist = artist;
        }
        public void setGenre(string genre)
        {
            this.genre = genre;
        }
        public string getTitle()
        {
            return this.title;
        }
        public int getDuration()
        {
            return this.duration;
        }
        public Artist getArtist()
        {
            return this.artist;
        }
        public string getGenre()
        {
            return this.genre;
        }

        public Song(string title, int duration, Artist artist, string genre)
        {
            this.title = title;
            this.duration = duration;
            this.artist = artist;
            this.genre = genre;
        }

        public void play()
        {
            Console.WriteLine("Playing " + this.title);
        }
        public void pause()
        {
            Console.WriteLine("Stopped " + this.title);
        }
        public void skip()
        {
            Console.WriteLine("Paused " + this.title);
        }
        public void previouse()
        {
            Console.WriteLine("Stopped " + this.title);
        }
        public void stop(bool shuffled)
        {
            Console.WriteLine("Stopped " + this.title);
        }


        public override string ToString()
        {
            return this.title + " - " + this.artist.getName() + " - " + this.duration + " - " + this.genre;
        }
    }
}
