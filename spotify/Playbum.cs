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

        public List<Song> getSong()
        {
            return this.songs;
        }

        public Playbum(int afspeeltijd)
        {
            this.afspeeltijd = afspeeltijd;
            this.songs = new List<Song>();
        }
        public void getSongs()
        {
            int i = 1;
            foreach (Song song in this.songs)
            {
                Console.WriteLine(i + ") " + song.getTitle());
                i++;
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

        public void addPlaybum(Playbum playalbum)
        {
            foreach (Song song in playalbum.songs)
            {
                this.addSong(song);
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
            if (shuffled)
            {
                Console.Write("Playing: ");
                int i = 0;
                int n = this.songs.Count;
                while (n > 1)
                {
                    n--;
                    int k = new Random().Next(n + 1);
                    Song value = this.songs[k];
                    this.songs[k] = this.songs[n];
                    this.songs[n] = value;
                }
                foreach (Song song in this.songs)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(song.getTitle());
                        Console.Write("Next: ");
                    }
                    else
                    {
                        Console.Write(song.getTitle());
                    }
                    i++;
                }
                Console.WriteLine("");
            }
            else 
            {
                Console.Write("Playing: ");
                int i = 0;
                foreach (Song song in this.songs)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(song.getTitle());
                        Console.Write("Next: ");
                    }
                    else
                    {
                        Console.Write(song.getTitle());
                    }
                    i++;
                }
                Console.WriteLine("");
            }
        }
        public void pause()
        {
            Console.WriteLine("Pausing list");
        }
        public void resume()
        {
            Console.WriteLine("Resuming list");
        }
        public void skip()
        {
            Console.WriteLine("Skipping song");
        }
        public void stop()
        {
            Console.WriteLine("Stopping list");
        }
    }
}
