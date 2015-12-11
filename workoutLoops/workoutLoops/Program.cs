using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workoutLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;

            //while(i < 11)
            //  {
            //   Console.WriteLine(i);
            //    i++;
            //  }

            //int n = 10;

            //do
            //{
            //    Console.WriteLine(n);
            //    n--;
            //} while (n > 0); 


            // LIST OF FAVORITE FOODS
            //string[] favoriteFoods = { "tacos", "Currywurst", "a full English breakfast", "bacon avocado cheeseburgers",
            //   "coffee", "Sauerkraut", "fried chicken", "au gratin potatoes", "macaroni and cheese",
            //   "cheesecake", "Kartoffelpuffer", "tortilla soup", "almost every food ever"};

            //Array.Reverse(favoriteFoods); //reverses the order of the array

            //foreach(string f in favoriteFoods)
            //{
            //    Console.WriteLine("I love " + f + ".");
            //}
            //Console.WriteLine("I am not discerning.");





            //string[] favoriteAuthors = { "Sir Terry Pratchett", "Robert Heinlein", "Douglas Adams", "Isaac Asimov",
            //                             "George Orwell", "Margaret Atwood"};
            //int favAuthorsLength = favoriteAuthors.Length;

            //int i;
            //for (i = 0; i < favAuthorsLength; i++)
            //    {
            //    Console.WriteLine(favoriteAuthors[i]);
            //    }


            //MAKE A TRIANGLE
            //int n = int.Parse(Console.ReadLine());              //asks for a number to count to 
            //for (int row = 1; row <= n; row++)                  //will make rows one by one until n is reached 
            //    {
            //    for (int col = 1; col <= row; col++)            //starts column, and will increment numbers by 1 until columns = rows
            //       {
            //        Console.Write(col + " ");                   //writes column number(s) on the row line
            //        }
            //    Console.WriteLine();                            //creates a new row
            //    }

            // int x = 5;
            // int y = 5;

            // for (int counterzero = 1; counterzero <= y; counterzero++) //rows (y)
            // {
            //     for (int counterone = 1; counterone <= x; counterone++) //columns (x)
            //     {
            //             Console.Write(counterone * counterzero + " ");  // column times row 
            //     }
            //     Console.WriteLine();
            // }


            int numRow = 4;     //number of rows
            int numCols = 4;    //number of columns

            for (int row = 0; row <= numRow-1; row++)
            {
                for (int cols = 0; cols <= numCols-1; cols++)
                {
                    Console.Write((row +1  * cols +1 ) + " "); //number of rows -1 * number of columns -1
                }
                Console.WriteLine(); 
            }


        }
    }
}
