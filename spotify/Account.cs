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
            return this.name;
        }
        public string getEmail()
        {
            return this.email;
        }

        private List<Person> friends { get; set; }
        private List<Playlist> playlists { get; set; }

        public List<Person> getFriend()
        {
            return this.friends;
        }
        public List<Playlist> getPlaylists()
        {
            return this.playlists;
        }
        public Playlist getPlaylist(string name)
        {
            foreach (Playlist p in playlists)
            {
                if (p.getName() == name)
                {
                    return p;
                }
            }
            return null;
        }
        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
            friends = new List<Person>();
            playlists = new List<Playlist>();
        }

        public List<Playlist> getFriendsPlaylists()
        {
            List<Playlist> list = new List<Playlist>();
            foreach (Person p in friends)
            {
                foreach (Playlist pl in p.getPlaylists())
                {
                    list.Add(pl);
                }
            }
            return list;
        }

        public void printFriendsPlaylists()
        {
            int i = 1;
            foreach (Person p in friends)
            {
                foreach (Playlist pl in p.getPlaylists())
                {
                    Console.WriteLine(i + ") " + p.getName() + ": " + pl.getName());
                    i++;
                }
            }
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
            int i = 1;
            foreach (Person friend in this.friends)
            {
                Console.WriteLine(i + ") " + friend.getName());
                i++;
            }
        }
        public void printPlaylists()
        {
            Console.WriteLine("Playlists of " + this.name + ":");
            int i = 1;
            foreach (Playlist playlist in this.playlists)
            {
                Console.WriteLine(i + ") " + playlist.getName());
                i++;
            }
        }
        public void getPlaylist()
        {
            
        }
        public int getPlaylistCount()
        {
            return this.playlists.Count;
        }
        
    }
}
