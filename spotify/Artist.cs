using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Artist
    {
        private List<Song> songs { get; set; }
        private List<Album> albums { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
        public Artist(string name, string email)
        {
            this.name = name;
            this.email = email;
            songs = new List<Song>();
            albums = new List<Album>();
        }


        public void addSong(Song song)
        {
            this.songs.Add(song);
        }
        public void removeSong(Song song)
        {
            this.songs.Remove(song);
        }
        public void addAlbum(Album album)
        {
            this.albums.Add(album);
        }
        public void removeAlbum(Album album)
        {
            this.albums.Remove(album);
        }
        public void printSongs()
        {
            Console.WriteLine("Songs of " + this.name + ":");
            foreach (Song song in this.songs)
            {
                Console.WriteLine(song.getTitle());
            }
        }
        public void printAlbums()
        {
            Console.WriteLine("Albums of " + this.name + ":");
            foreach (Album album in this.albums)
            {
                Console.WriteLine(album.getname());
            }
        }

        public int getSongCount(List<Song> songs)
        {
            return songs.Count;
        }
        public int getAlbumCount(List<Album> albums)
        {
            return albums.Count;
        }
        
    }
}
