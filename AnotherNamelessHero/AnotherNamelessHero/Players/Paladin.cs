using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Paladin : Player
    {
        public Paladin()
        {
            name = "Paladin";
            HP_full = 300;
            HP_current = 300;
            MP_full = 100;
            MP_current = 100;
            max_attack = 20;
            magic_cure = 30;
            magic_light = 20;
        }
    }
}
