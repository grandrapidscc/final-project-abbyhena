using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public class Locations
   {
    public static void firstLocation()
    {
        int[][] jaggedArray= new int[][]
            {
                new int[] {0,1,2,3,4},
                new int[] {0,1,2,3,4},
                new int[] {0,1,2,3,4},
                new int[] {0,1,2,3,4},
                new int[] {0,1,2,3,4}
            };
            int i = 1;
            int j = 1;
            int initial_wizert_loc = jaggedArray[i][j];
            string choice;
            Console.WriteLine("Which direction would you like to move?");
            Console.WriteLine("1.North");
            Console.WriteLine("2.East");
            Console.WriteLine("3.South");
            Console.WriteLine("4.West");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                initial_wizert_loc = jaggedArray[i - 1][j];
            }
            else if (choice == "2")
            {
                initial_wizert_loc = jaggedArray[i][j+1];
            }
             else if (choice == "3")
            {
                initial_wizert_loc = jaggedArray[i+1][j];
            }
             else if (choice == "4")
            {
                initial_wizert_loc = jaggedArray[i][j-1];
            }

    }
   }