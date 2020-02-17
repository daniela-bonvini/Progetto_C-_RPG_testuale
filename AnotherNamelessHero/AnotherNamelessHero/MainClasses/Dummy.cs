using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Dummy
    {
        protected string name;
        protected int HP_full;
        protected int HP_current;
        protected int MP_full;
        protected int MP_current;
        protected int max_attack;

        public string Get_name
        {
            get { return name; }
        }

        public int Get_HP_full
        {
            get { return HP_full; }
            set { HP_full = value; }
        }

        public int Get_HP_current
        {
            get { return HP_current; }
            set { HP_current = value; }
        }

        public int Get_MP_full
        {
            get { return MP_full; }
            set { MP_full = value; }
        }

        public int Get_MP_current
        {
            get { return MP_current; }
            set { MP_current = value; }
        }

        public int Get_max_attack
        {
            get { return max_attack; }
        }

    }
}

