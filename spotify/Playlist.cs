using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Playlist : Iplaybum
    {
        private string name { get; set; }
        private bool online { get; set; }
        private List<Song> songs { get; set; }
        private Person creator { get; set; }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setOnline(bool online)
        {
            this.online = online;
        }
        public void setCreator(Person creator)
        {
            this.creator = creator;
        }
        public string getName()
        {
            return this.name;
        }
        public bool getOnline()
        {
            return this.online;
        }
        public Person getCreator()
        {
            return this.creator;
        }

        public Playlist(string name, bool online, Person creator)
        {
            this.name = name;
            this.online = online;
            this.creator = creator;
            songs = new List<Song>();
        }

        public void addSong(Song song)
        {
            this.songs.Add(song);
        }
        public void removeSong(Song song)
        {
            this.songs.Remove(song);
        }
        public List<Song> getSongs()
        {
            return this.songs;
        }
        public object getListCreator()
        {
            return this.creator;
        }
        public void printlist()
        {
            Console.WriteLine("Playlist: " + this.name);
            Console.WriteLine("Creator: " + this.creator.getName());
            Console.WriteLine("Songs: ");
            foreach (Song song in this.songs)
            {
                Console.WriteLine(song.getTitle());
            }
        }
        
    }
}
