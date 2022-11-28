using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Encounters
   {
    //Encounters with monsters
    public static void firstEncounter()
    {
        Console.WriteLine("You instantly go into attack mode on sight of the first monster and run towards it.");
        Console.WriteLine("The monster looks shocked for a moment but then gets ready...");
        Console.ReadKey();
    }

    //fighting

    public static void Combat(string name, int power, int health)
    {
        string n = name;
        int p = power;
        int h = health;

        while(h > 0)
        {
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("(A)ttack");
            Console.WriteLine("(F)lee");
            Console.WriteLine("(H)eal");
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine(" Potions" +FinalProject.Program.currentPlayer.powerup + "Health" +FinalProject.Program.currentPlayer.health);
            string temp = Console.ReadLine();
            temp.ToLower();

            
            if ((temp == "a") || (temp == "attack"))
            {
                //Attack
            }
            else if ((temp == "f") || (temp == "flee"))
            {
                //Flee
            }
            else if ((temp == "h") || (temp == "heal"))
            {
                //Heal
            }
        }
    }
   }