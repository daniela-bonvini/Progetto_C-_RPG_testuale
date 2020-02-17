using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Dragon : Monster
    {
        public Dragon()
        {
            name = "Dragon";
            HP_full = 500;
            HP_current = 500;
            MP_full = 50;
            MP_current = 50;
            max_attack = 50;
            EXP_given = 1000;
        }
    }
}