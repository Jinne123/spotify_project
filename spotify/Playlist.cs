using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Playlist : Playbum
    {
        private string name { get; set; }
        private bool online { get; set; }
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

        public Playlist(int afspeeltijd, string name, bool online, Person creator) : base(afspeeltijd)
        {
            this.name = name;
            this.online = online;
            this.creator = creator;
        }

        public override object getListCreator()
        {
            return this.creator;
        }
        public override void printlist()
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
