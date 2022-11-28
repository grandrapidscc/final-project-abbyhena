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

        }
    }
}

