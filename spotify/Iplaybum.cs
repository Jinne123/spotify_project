using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal interface Iplaybum
    {
        public void addSong(Song song);
        public void removeSong(Song song);
        public List<Song> getSongs();
        public object getListCreator();
        public void printlist();


    }
}
