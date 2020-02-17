using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNamelessHero
{
    class Combat
    {
        public static int Fight(Player player, Monster enemy, int game_over)
        {
            Random rnd = new Random();
            bool operation_result = true;
            int attack_choice;
            int damageToMonster = 0;

            do
            {
                Console.WriteLine("\nWhich attack do you want to perform?");
                Console.WriteLine(" 1 - Physical attack");
                Console.WriteLine(" 2 - Magic attack: Lightning");
                Console.WriteLine(" 3 - Magic: cure wounds\n");

                //checks if player input is a valid number
                string temp = Console.ReadLine();
                operation_result = int.TryParse(temp, out attack_choice);

                if (attack_choice < 1 || attack_choice > 3)
                {
                    Console.WriteLine("\nAlas, your choice was incorrect. Please choose a number between 1 and 3.");
                    operation_result = false;
                }

            } while (!operation_result);
            
            if(attack_choice == 1) { 
                // Determine the amount of physical damage to do to the monster
                damageToMonster = rnd.Next(0, player.Get_max_attack);

                // Apply the damage to the monster's CurrentHitPoints
                enemy.Get_HP_current -= damageToMonster;

                // Display message
                Console.WriteLine("\nYou hit the " + enemy.Get_name + " for " + damageToMonster.ToString() + " points of physical damage.");
                Console.WriteLine(enemy.Get_name + " HP: " + enemy.Get_HP_current + "/" + enemy.Get_HP_full + "\n");
            }
            else if(attack_choice == 2)
            {
                //checks if player has enough MP
                if (player.Get_MP_current < player.Get_magic_light)
                {
                    Console.WriteLine("\nToo bad, insufficient MP.");
                }
                else
                { 
                    // Determine the amount of magic damage to do to the monster
                    damageToMonster = player.Get_magic_light;
                    player.Get_MP_current -= player.Get_magic_light;

                    // Apply the damage to the monster's CurrentHitPoints
                    enemy.Get_HP_current -= damageToMonster;

                    // Display message
                    Console.WriteLine("\nYou hit the " + enemy.Get_name + " for " + damageToMonster.ToString() + " points of magic damage.");
                    Console.WriteLine(enemy.Get_name + " HP: " + enemy.Get_HP_current + "/" + enemy.Get_HP_full + "\n");
                }
            }
            else if (attack_choice == 3)
            {
                //checks if player has enough MP
                if (player.Get_MP_current < player.Get_magic_cure)
                {
                    Console.WriteLine("\nToo bad, insufficient MP.\n");
                }
                else
                {
                    player.Get_MP_current -= player.Get_magic_cure;

                    // Determine the amount of cure to do to player
                    if ((player.Get_HP_current += player.Get_magic_cure) > player.Get_HP_full)
                    {
                        player.Get_HP_current = player.Get_HP_full;
                    }
                    else
                    {
                        player.Get_HP_current += player.Get_magic_cure;
                    }

                    // Display message
                    Console.WriteLine("\nYou restored your HP by " + player.Get_magic_cure + " points.\n");
                }
            }

            System.Threading.Thread.Sleep(2500);

            // Check if the monster is dead
            if (enemy.Get_HP_current <= 0)
            {
                if (enemy.Get_name == "Dragon")
                {
                    Console.WriteLine("\nCongratulations hero, you've become the heroest in all the land. ");
                    Console.WriteLine("Good job, very impressed, you're very strong and so on. ");
                    Console.WriteLine("Now scat, I've got other more important things to attend to.");
                    Console.WriteLine("\n\nTHE END");

                    System.Threading.Thread.Sleep(6000);
                    return game_over = 1;
                }
                else
                {
                    // Monster is dead
                    Console.WriteLine("\nYou've slain the fearsome beast! Rejoice!\n");

                    // Give player experience points for killing the monster
                    player.Get_EXP_current += enemy.Get_EXP_given;
                    Console.WriteLine("\nYou receive " + enemy.Get_EXP_given.ToString() + " experience points.\n");

                    //Check if level up is possible
                    if (player.Get_EXP_current >= player.Get_EXP_full)
                    {
                        player.Get_EXP_current -= player.Get_EXP_full;
                        player.Get_level += 1;
                        player.Get_HP_current = (player.Get_HP_full += 50 * player.Get_level);
                        player.Get_MP_current = (player.Get_MP_full += 50 * player.Get_level);

                        Console.WriteLine("\nCongrats! You just leveled up, you awesome hero, you.\n");
                        Console.WriteLine("HP and MP fully replenished.\n");
                        System.Threading.Thread.Sleep(3000);
                    }

                    //Program waits 2 seconds to let the player read the message on screen
                    System.Threading.Thread.Sleep(2000);

                    // Refresh player information
                    GUI.Draw_Game_Screen(player.Get_player_name, player.Get_name, player.Get_HP_current, player.Get_HP_full,
                                         player.Get_MP_current, player.Get_MP_full, player.Get_EXP_current, player.Get_EXP_current,
                                         player.Get_level);

                }
            }
            else // Monster is still alive
            {

                // Determine the amount of damage the monster does to the player
                int damageToPlayer = rnd.Next(0, enemy.Get_max_attack);

                // Display message
                Console.WriteLine("The " + enemy.Get_name + " did " + damageToPlayer.ToString() + " points of damage to you.\n");

                // Subtract damage from player
                player.Get_HP_current -= damageToPlayer;

                //Program waits 2 seconds to let the player read the message on screen
                System.Threading.Thread.Sleep(2000);

                // Refresh player information
                GUI.Draw_Game_Screen(player.Get_player_name, player.Get_name, player.Get_HP_current, player.Get_HP_full,
                                     player.Get_MP_current, player.Get_MP_full, player.Get_EXP_current, player.Get_EXP_current,
                                     player.Get_level);

                if (player.Get_HP_current <= 0)
                {
                    Console.WriteLine("\nSadly, my dearest " + player.Get_player_name + ", you died!\n" +
                                      "Oh well, another fearless \"irreplaceable\" hero " +
                                      "will take your place in saving the world.\n" +
                                      "Thank you for playing!\n");
                    Console.WriteLine("GAME OVER\n");

                    System.Threading.Thread.Sleep(6000);

                    game_over = 1;
                }
            }
            return game_over;
        }
    }
}

