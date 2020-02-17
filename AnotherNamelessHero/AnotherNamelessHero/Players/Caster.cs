using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Caster : Player
    {
        public Caster()
        {
            name = "Caster";
            HP_full = 100;
            HP_current = 100;
            MP_full = 300;
            MP_current = 300;
            max_attack = 10;
            magic_cure = 60;
            magic_light = 50;
        }
    }
}
