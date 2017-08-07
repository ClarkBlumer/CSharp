using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace CreatureKingdom
{
    class BlumerClarkCreature : Creature
    {
        public BlumerClarkCreature(Canvas kingdom, Dispatcher dispatcher, int waitTime = 100) : base(kingdom, dispatcher, waitTime)
        {
            
        }
    }
}
