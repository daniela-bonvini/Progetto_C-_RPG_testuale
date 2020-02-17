using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Fighter : Player
    {
        public Fighter()
        {
            name = "Fighter";
            HP_full = 150;
            HP_current = 150;
            MP_full = 200;
            MP_current = 200;
            max_attack = 15;
            magic_cure = 40;
            magic_light = 30;
        }
    }
}

