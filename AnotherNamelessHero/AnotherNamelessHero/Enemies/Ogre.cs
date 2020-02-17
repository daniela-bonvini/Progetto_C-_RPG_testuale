using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Ogre : Monster
    {

        public Ogre()
        {
            name = "Ogre";
            HP_full = 50;
            HP_current = 50;
            MP_full = 50;
            MP_current = 50;
            max_attack = 20;
            EXP_given = 50;
        }
    }
}

