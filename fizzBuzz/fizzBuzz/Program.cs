using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to count up to.");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a number to divide by for 'fizz'.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a number to divie by for 'buzz'.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now let's go!  Press enter to cotinue.");
            Console.ReadLine();

            int count; 

            for (count=0; count <= z; count++)
            {

                if ((count % x == 0) && (count % y == 0))
                     {
                    Console.WriteLine("fizzbuzz");
                     }
                else
                {
                    if (count % y == 0)
                         {
                        Console.WriteLine("buzz");
                         }
                    else
                    {
                        if (count % x == 0)
                            {
                            Console.WriteLine("fizz");
                            }
                        else
                            { }
                    }

                 Console.WriteLine(count);
                }


            }
        }
        
    }
}
