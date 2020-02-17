using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class GUI
    {

        public static void Draw_Game_Screen(string char_name, string char_class, int char_HP_current, int char_HP_full,
                                            int char_MP_full, int Char_MP_full, int char_EXP_current, int char_EXP_full, int char_level)
        {

            //Draw stats
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("Name: {0}", char_name);
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("Class: {0}", char_class);
            Console.SetCursorPosition(53, 1);
            Console.WriteLine("HP: {0}/{1}", char_HP_current, char_HP_full);
            Console.SetCursorPosition(70, 1);
            Console.WriteLine("MP: {0}/{1}", char_MP_full, Char_MP_full);
            Console.SetCursorPosition(87, 1);
            Console.WriteLine("EXP: {0}/{1}", char_EXP_current, char_EXP_full);
            Console.SetCursorPosition(107, 1);
            Console.WriteLine("level: {0}", char_level);
            Console.WriteLine("________________________________________________________________________________________________________________________");
        } //end Draw_Game_Screen

        public static void Options_menu(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("CLASSES STATS");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.WriteLine("CASTER: a powerful magician, low HP and attack but high MP and magic power.");
                    Console.WriteLine("HP = 100, MP = 300, Physical Attack = 10, Magic attack = 50, Magic cure = 60");
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("FIGHTER: a balanced choice, equilibrium is his best asset.");
                    Console.WriteLine("HP = 150, MP = 200, Physical Attack = 15, Magic attack = 30, Magic cure = 40");
                    Console.WriteLine("________________________________________________________________________________________________________________________");
                    Console.WriteLine("PALADIN: a strong warrior of light, low MP and magic but high HP and physical attack.");
                    Console.WriteLine("HP = 300, MP = 100, Physical Attack = 20, Magic attack = 20, Magic cure = 30\n\n");
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("HELP");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.WriteLine("This game is a funny take on all the classic RPGs out there,");
                    Console.WriteLine("by whose standards there should be thousands of unique chosen heroes of the legend.");
                    Console.WriteLine("You can choose our nxt action via the command menu and taping the number\n" +
                                      "corresponding to the action which you want to do.");
                    Console.WriteLine("The game story is fairly simple: you choose to be one among three stereotypical fantasy classes");
                    Console.WriteLine("and then fight monsters until you become powerful enough to face the final boss,");
                    Console.WriteLine("ultimately freeing the land and all its inhabitants.\nThat is, unless you die first.");
                    Console.WriteLine("During your adventure you will encounter 4 different types of monsters,\n" +
                                      "in increasing level of difficulty: slimes, kobolds, ogres and if you're (un)lucky even a dragon");
                    Console.WriteLine("As I see you're new around here, let me give you a friendly advice:\n" +
                                      "don't try to run, they will always catch you.\n\n");
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("INFO");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("------------------------------------------------------------------------------------------------------------------------\n\n");
                    Console.WriteLine("\'Another Nameless Hero\' created by Daniela Bonvini & Andrea De Luna.");
                    Console.WriteLine("Made for Programmazione a Oggetti e Ingegneria del Software by Edoardo Bonta\', AA. 2019/2020\n\n");
                    break;
            }
        }

    } //end class GUI
}