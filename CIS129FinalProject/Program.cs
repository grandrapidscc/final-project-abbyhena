using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.firstEncounter();
            Congrats();
            Locations.firstLocation();
            Second();
            Encounters.secondEncounter();
            Congrats();
        }

        static void Start()
        {
            Console.WriteLine("Wizert Game");
            Console.WriteLine("Enter player name to begin:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You stir awake, feeling dizzy and cold.");
            Console.WriteLine("Your surrounding are unfamiliar and pretty quickly, you realize you are trapped in a dungeon");
            if (currentPlayer.name == "")
              Console.WriteLine("You don't remember your name...");
              else
              Console.WriteLine("You know your name is " + currentPlayer.name);
              Console.ReadKey();
              Console.Clear();
              Console.WriteLine("You feel the cold walls around you trying to find a way out");
              Console.WriteLine("Your hand suddenly feels a doorknob");
              Console.WriteLine("You expected it to be locked but with a twist it opens easily");
              Console.WriteLine("You find a monster in the shadows of the next room");
        }

        static void Congrats()
        {
            Console.WriteLine("Congrats on defeating/getting away from the monster!");
        }
        static void Second()
        {
            Console.WriteLine("You can hear the screeches of this monster from afar...");
            Console.WriteLine("A banshee! Those are powerful. It might be wise to flee");
            
        }
    }
}

