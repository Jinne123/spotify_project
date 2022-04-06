using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Person
    {
        private string name;
        public string Name { get { return this.name; } set { this.name = value; } }
        private string email;
        public string Email { get { return this.email; } set { this.email = value; } }
        private List<Person> friends;
        public List<Person> Friends { get { return this.friends; } set { this.friends = value; } }
        private List<Playlist> playlists;
        public List<Playlist> Playlists { get { return this.playlists; } set { this.playlists = value; } }
        /*        public List<Song> favSongs;
                public List<Album> favAlbums;
                public List<Playlist> favPlaylists;     */
        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
            this.friends = new List<Person>();
            this.playlists = new List<Playlist>();
        }
        public void addFriend(Person friend)
        {
            this.friends.Add(friend);
        }
        public void addPlaylist(Playlist playlist)
        {
            this.playlists.Add(playlist);
        }
        public void removeFriend(Person friend)
        {
            this.friends.Remove(friend);
        }
        public void removePlaylist(Playlist playlist)
        {
            this.playlists.Remove(playlist);
        }
        public void printFriends()
        {
            Console.WriteLine("Friends of " + this.name + ":");
            foreach (Person friend in this.friends)
            {
                Console.WriteLine(friend.name);
            }
        }
        public void printPlaylists()
        {
            Console.WriteLine("Playlists of " + this.name + ":");
            foreach (Playlist playlist in this.playlists)
            {
                Console.WriteLine(playlist.Name);
            }
        }
        
    }
/*    internal class Friend
    {
        
    }*/
}
