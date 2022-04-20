using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Playbum : Iplayable
    {
        private int afspeeltijd;
        public List<Song> songs;
        public int getAfspeeltijd()
        {
            return afspeeltijd;
        }
        public void setAfspeeltijd(int afspeeltijd)
        {
            this.afspeeltijd = afspeeltijd;
        }

        public Playbum(int afspeeltijd)
        {
            this.afspeeltijd = afspeeltijd;
            this.songs = new List<Song>();
        }
        public void getSongs()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.getTitle());
            }
        }
        public virtual object getListCreator()
        {
            return null;
        }
        public virtual void printlist()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.getTitle());
            }
        }

        public void addSong(Song song)
        {
            this.songs.Add(song);
        }
        public void removeSong(Song song)
        {
            this.songs.Remove(song);
        }

        public void play(bool shuffled)
        {
            Console.WriteLine("Playing album");
        }
        public void pause(){
            Console.WriteLine("Pausing album");
        }
        public void skip()
        {
            Console.WriteLine("Skipping song");
        }
        public void previouse()
        {
            Console.WriteLine("Previous song");
        }
        public void stop(){
            Console.WriteLine("Stopping album");
        }
    }
}
