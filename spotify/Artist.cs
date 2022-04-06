using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Artist : Person
    {
        private bool isArtist;
        public List<Song> songs;
        public List<Album> albums;
        
        public bool IsArtist
        {
            get { return this.isArtist; }
        }
        public Artist(string name, string email, bool isAtist) : base(name, email)
        {
            this.isArtist = isAtist;
            this.songs = new List<Song>();
            this.albums = new List<Album>();
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
            Console.WriteLine("Songs of " + this.Name + ":");
            foreach (Song song in this.songs)
            {
                Console.WriteLine(song.Title);
            }
        }
        public void printAlbums()
        {
            Console.WriteLine("Albums of " + this.Name + ":");
            foreach (Album album in this.albums)
            {
                Console.WriteLine(album.Title);
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
