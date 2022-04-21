using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Album : Playbum
    {
        private string description { get; set; }
        private string name { get; set; }
        private string genre { get; set; }
        private string releaseDate { get; set; }
        private Artist artist;

        public void setdescription(string description)
        {
            this.description = description;
        }
        public string getdescription()
        {
            return description;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }
        public void setgenre(string genre)
        {
            this.genre = genre;
        }
        public string getgenre()
        {
            return genre;
        }
        public void setreleaseDate(string releaseDate)
        {
            this.releaseDate = releaseDate;
        }
        public string getreleaseDate()
        {
            return releaseDate;
        }
        public void setartist(Artist artist)
        {
            this.artist = artist;
        }
        public Artist getartist()
        {
            return artist;
        }

        public Album(int afspeeltijd, string description, string name, string genre, string releaseDate, Artist artist) : base(afspeeltijd)
        {
            this.description = description;
            this.name = name;
            this.genre = genre;
            this.releaseDate = releaseDate;
            this.artist = artist;
            this.songs = new List<Song>();
        }
        
        public override object getListCreator()
        {
            return this.artist;
        }

        public override void printlist()
        {
            Console.WriteLine("Album: " + this.name);
            Console.WriteLine("Description: " + this.description);
            Console.WriteLine("Genre: " + this.genre);
            Console.WriteLine("Release Date: " + this.releaseDate);
            Console.WriteLine("Artist: " + this.artist.getName());
            foreach (Song song in this.songs)
            {
                Console.WriteLine(song.getTitle());
            }
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
