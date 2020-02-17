using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Kobold : Monster
    {
        public Kobold()
        {
            name = "Kobold";
            HP_full = 25;
            HP_current = 25;
            MP_full = 25;
            MP_current = 25;
            max_attack = 10;
            EXP_given = 25;
        }
    }
}