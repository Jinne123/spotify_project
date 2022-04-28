using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify
{
    internal interface Iplayable
    {
        void play(bool shuffled);
        void resume();
        void pause();
        void skip();
        void stop();
    }
}
