using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Monster : Dummy
    {

        protected int EXP_given;


        public int Get_EXP_given
        {
            get { return EXP_given; }
        }

    }
}

