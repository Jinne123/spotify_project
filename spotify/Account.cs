using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Person
    {
        public string Name;
        public string Email;
        public List<Friend> friends;
        public List<Song> songs;
        public List<Album> albums;
        public List<Playlist> playlists;
        /*        public List<Song> favSongs;
                public List<Album> favAlbums;
                public List<Playlist> favPlaylists;     */
        public Person(string name, string email)
        {
            this.Name = name;
            this.Email = email;
            this.friends = new List<Friend>();
            this.songs = new List<Song>();
            this.albums = new List<Album>();
            this.playlists = new List<Playlist>();
        }
        public void addFriend(Friend friend)
        {
            this.friends.Add(friend);
        }
        public void addSong(Song song)
        {
            this.songs.Add(song);
        }
        public void addAlbum(Album album)
        {
            this.albums.Add(album);
        }
        public void addPlaylist(Playlist playlist)
        {
            this.playlists.Add(playlist);
        }
        public void removeFriend(Friend friend)
        {
            this.friends.Remove(friend);
        }
        public void removeSong(Song song)
        {
            this.songs.Remove(song);
        }
        public void removeAlbum(Album album)
        {
            this.albums.Remove(album);
        }
        public void removePlaylist(Playlist playlist)
        {
            this.playlists.Remove(playlist);
        }
        public void printFriends()
        {
            Console.WriteLine("Friends of " + this.Name + ":");
            foreach (Friend friend in this.friends)
            {
                Console.WriteLine(friend.Name);
            }
        }
        public void printSongs()
        {
            Console.WriteLine("Songs of " + this.Name + ":");
            foreach (Song song in this.songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        public void printAlbums()
        {
            Console.WriteLine("Albums of " + this.Name + ":");
            foreach (Album album in this.albums)
            {
                Console.WriteLine(album.Name);
            }
        }
        public void printPlaylists()
        {
            Console.WriteLine("Playlists of " + this.Name + ":");
            foreach (Playlist playlist in this.playlists)
            {
                Console.WriteLine(playlist.Name);
            }
        }
        
    }
    internal class Friend
    {
        
    }
}
