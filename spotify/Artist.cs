using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal class Artist
    {
        public string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Artist(string name)
        {
            Name = name;
        }
    }
}
