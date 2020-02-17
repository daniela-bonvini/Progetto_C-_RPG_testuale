using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Slime : Monster
    {
        public Slime()
        {
            name = "Slime";
            HP_full = 10;
            HP_current = 10;
            MP_full = 10;
            MP_current = 10;
            max_attack = 5;
            EXP_given = 10;
        }
    }
}