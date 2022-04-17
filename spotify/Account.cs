using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Person
    {
        private string name { get; set; }
        private string email { get; set; }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }

        private List<Person> friends { get; set; }
        private List<Playlist> playlists { get; set; }

        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
            friends = new List<Person>();
            playlists = new List<Playlist>();
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
                Console.WriteLine(playlist.getName());
            }
        }
        
    }
}
