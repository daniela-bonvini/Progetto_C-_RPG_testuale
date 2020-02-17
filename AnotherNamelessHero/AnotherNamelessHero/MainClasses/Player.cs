using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Player : Dummy
    {
        private readonly string player_name = "Another Nameless Hero";
        protected int EXP_current = 0;
        protected int EXP_full = 100;
        protected int level = 1;
        protected int magic_cure;
        protected int magic_light;

        public string Get_player_name
        {
            get { return player_name; }
        }

        public int Get_EXP_current
        {
            get { return EXP_current; }
            set { EXP_current = value; }
        }

        public int Get_EXP_full
        {
            get { return EXP_full; }
        }

        public int Get_level
        {
            get { return level; }
            set { level = value; }
        }

        public int Get_magic_cure
        {
            get { return magic_cure; }
        }

        public int Get_magic_light
        {
            get { return magic_light; }
        }
    }
}

