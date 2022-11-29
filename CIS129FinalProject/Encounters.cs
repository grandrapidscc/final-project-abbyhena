using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Encounters
   {
    static Random rand = new Random();
    //Encounters with monsters
    public static void firstEncounter()
    {
        Console.WriteLine("You instantly go into attack mode on sight of the first monster and run towards it.");
        Console.WriteLine("The monster looks shocked for a moment but then gets ready...");
        Console.ReadKey();
        Combat("Goblin", 2, 3);
    }

    public static void secondEncounter()
    {
        Combat("Banshee", 8, 5);
    }

    //fighting

    public static void Combat(string name, int power, int health)
    {
        string n = name;
        int p = power;
        int h = health;

        while(h > 0)
        { Console.WriteLine(name);
        Console.WriteLine("Power: " +power);
        Console.WriteLine("Health: " +health);
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("(A)ttack");
            Console.WriteLine("(F)lee");
            Console.WriteLine("(H)eal");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine(" Potions " +FinalProject.Program.currentPlayer.powerup + " Health " +FinalProject.Program.currentPlayer.health);
            string temp = Console.ReadLine();
            temp.ToLower();

            
            if ((temp == "a") || (temp == "attack"))
            {
                //Attack
                Console.WriteLine("You swipe a fireball");
                Console.WriteLine("The enemy attacks you back");
                int damage = p - FinalProject.Program.currentPlayer.health;
                int attack = 5;
                Console.WriteLine("You lose " +damage + " and give " + attack + " damage");
                FinalProject.Program.currentPlayer.health -= damage;
                h -=attack;
            }
            else if ((temp == "f") || (temp == "flee"))
            {
                //Flee
                if (rand.Next(0,2) == 0)
                {
                    Console.WriteLine("Flee unsuccessful!");
                    int damage = p - FinalProject.Program.currentPlayer.health;
                    Console.WriteLine("You lose " +damage);
                    FinalProject.Program.currentPlayer.health -= damage;
                    Console.WriteLine("Press a key to continue");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("You have successfully fled");
                    Console.WriteLine("Press a key to continue");
                    break;
                }
            }
            else if ((temp == "h") || (temp == "heal"))
            {
                //Heal
                if (FinalProject.Program.currentPlayer.powerup == 0)
                {
                    Console.WriteLine("You have zero potions!");
                }
                else
                {
                    Console.WriteLine("You find a potion");
                    int hea = 5;
                    Console.WriteLine("You gain" + hea + " health");
                    FinalProject.Program.currentPlayer.health += hea;

                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
   }