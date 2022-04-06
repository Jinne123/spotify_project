using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Playlist
    {
        private string name;
        public string Name { get { return this.name; } set { this.name = value; } }
        private List<Song> songs;
        public List<Song> Songs { get { return this.songs; } set { this.songs = value; } }
        private Person creator;
        public Person Creator { get { return this.creator; } set { this.creator = value; } }
        public Playlist(string name, Person creator)
        {
            this.name = name;
            this.creator = creator;
            this.songs = new List<Song>();
        }
        public void AddSong(Song song)
        {
            this.songs.Add(song);
        }
        public void RemoveSong(Song song)
        {
            this.songs.Remove(song);
        }
        public void PrintPlaylist()
        {
            Console.WriteLine("Playlist: " + this.name);
            Console.WriteLine("Creator: " + this.creator.Name);
            Console.WriteLine("Songs: ");
            foreach (Song song in this.songs)
            {
                Console.WriteLine(song.Title);
            }
        }
        
    }
}
