using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Album
    {
        private string description;
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        private string title;
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        private string genre;
        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }
        private string releaseDate;
        public string ReleaseDate
        {
            get { return this.releaseDate; }
            set { this.releaseDate = value; }
        }
        private Artist artist;
        private List<Song> songs;
        public Album(string title, string genre, string releaseDate, string description, Artist artist)
        {
            this.artist = artist;
            this.title = title;
            this.genre = genre;
            this.releaseDate = releaseDate;
            this.description = description;
            this.songs = new List<Song>();
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
        public Artist getArtist()
        {
            return this.artist;
        }
        public override string ToString()
        {
            return this.title;
        }
    }
}
