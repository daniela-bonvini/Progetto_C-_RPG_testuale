using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int game_over = 0;
            int class_choice;
            string char_name;
            int fight_choice;
            bool operation_result = true;
            bool read_result = true;
            int menu_choice;
            Player player = new Player();
            Monster enemy = new Monster();
            Random rnd = new Random();

            //intro
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ANOTHER NAMELESS HERO");
            Console.Write("------------------------------------------------------------------------------------------------------------------------");
            Console.Write("------------------------------------------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("Welcome mighty traveler, please tell me your name, " +
                              "as to remember it for the ages to come: \n");
            char_name = Console.ReadLine();
            Console.WriteLine("\nVery well, " + char_name + ", it is a fearsome name indeed.\n\n");

            do
            {
                
                Console.WriteLine("Now, hero, what operation do you want to perform?\n");
                Console.WriteLine(" 1 - Class stats");
                Console.WriteLine(" 2 - Play game");
                Console.WriteLine(" 3 - Help");
                Console.WriteLine(" 4 - Info\n");

                string temp = Console.ReadLine();
                read_result = int.TryParse(temp, out menu_choice);

                if (menu_choice < 1 || menu_choice > 4)
                {
                    Console.WriteLine("\nAlas, your choice was incorrect. Please choose a number between 1 and 4.");
                    read_result = false;
                }

                if (menu_choice == 1 || menu_choice == 3 || menu_choice == 4)
                {
                    GUI.Options_menu(menu_choice);
                }


            } while (menu_choice != 2);

            do
            {
                Console.Clear();
                Console.Write("------------------------------------------------------------------------------------------------------------------------");
                Console.Write("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("ANOTHER NAMELESS HERO");
                Console.Write("------------------------------------------------------------------------------------------------------------------------");
                Console.Write("------------------------------------------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Good, now tell me, which class are you?");
                Console.WriteLine(" 1 - Caster");
                Console.WriteLine(" 2 - Fighter");
                Console.WriteLine(" 3 - Paladin\n");

                //checks if player input is a valid number
                string temp = Console.ReadLine();
                operation_result = int.TryParse(temp, out class_choice);

                if (class_choice < 1 || class_choice > 3)
                {
                    Console.WriteLine("\nAlas, your choice was incorrect. Please choose a number between 1 and 3.");
                    operation_result = false;
                }

            } while (!operation_result);

            //creates instance of player class
            switch (class_choice)
            {
                //caster
                case 1:
                    Caster caster = new Caster();
                    player = caster;
                    break;

                //fighter
                case 2:
                    Fighter fighter = new Fighter();
                    player = fighter;
                    break;

                //paladin
                case 3:
                    Paladin paladin = new Paladin();
                    player = paladin;
                    break;
            }

            GUI.Draw_Game_Screen(player.Get_player_name, player.Get_name, player.Get_HP_current, player.Get_HP_full,
                                 player.Get_MP_current, player.Get_MP_full, player.Get_EXP_current, player.Get_EXP_current,
                                 player.Get_level);

            do
            {
                int encounter = rnd.Next(0, 100);

                if (player.Get_level == 4)
                {
                    Dragon dragon = new Dragon();
                    enemy = dragon;
                    Console.WriteLine("\nYour heroic deeds have travelled far and wide and have captured\n" +
                                        "the attention of the Evil Dragon that terrorizes the kingdom.\n" +
                                        "You have no choice but to fight it to the death.\n");

                }
                else {
                    //creates monster instance with variable percentages
                    if (encounter < 50)
                    {
                        Slime slime = new Slime();
                        enemy = slime;
                    }
                    else if (encounter > 60 && encounter < 80)
                    {
                        Kobold kobold = new Kobold();
                        enemy = kobold;
                    }
                    else
                    {
                        Ogre ogre = new Ogre();
                        enemy = ogre;
                    }
                }

                do
                {
                    Console.WriteLine("\nA fearsome " + enemy.Get_name + " approaches and tries to attack you. " +
                                      "What do you want to do?");
                    Console.WriteLine(" 1 - Fight the unholy creature");
                    Console.WriteLine(" 2 - Run like a wimp\n");

                    operation_result = int.TryParse(Console.ReadLine(), out fight_choice);

                    if (fight_choice < 1 || fight_choice > 2)
                    {
                        Console.WriteLine("\nAlas, your choice was incorrect. Please choose a number between 1 and 2.");
                        operation_result = false;
                    }

                } while (!operation_result);

                    switch (fight_choice)
                    {
                        //fight until hero is alive
                        case 1:
                            do
                            {
                                Combat.Fight(player, enemy, game_over);
                                if ((enemy.Get_name == "Dragon" && enemy.Get_HP_current <= 0) || (player.Get_HP_current <= 0))
                                {
                                    game_over = 1;
                                }
                            } while (enemy.Get_HP_current > 0 && game_over == 0);
                            break;

                        //run away and game over
                        case 2:
                            Console.WriteLine("\nYou try to outrun the mighty beast but in the end it catches you.\n");
                            Console.WriteLine("Sadly, my dearest ''"+ player.Get_player_name + "'', you lost! But don't worry, your cowardice");
                            Console.WriteLine("will be know all over the land and another fearless \"irreplaceable\" hero");
                            Console.WriteLine("will take your place in saving the world. Thank you for playing!\n\n");
                            Console.WriteLine("GAME OVER\n");
                            System.Threading.Thread.Sleep(10000);
                            game_over = 1;
                            break;
                    }
               
            } while (game_over == 0);
        }//end main
    }//end class program
}

