using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you now?");
                int ageNow = int.Parse(Console.ReadLine());
                Console.WriteLine("You will be " + (ageNow + 85) + " at the turn of the next century."); 
            }
           catch(System.FormatException notANumber)
           {
                Console.WriteLine(notANumber.Message); 
                // throw;
               // throw new FormatException("Input must be numerical ", notANumber); 
             }
            finally
            {
                Console.WriteLine("Goodbye."); 
            }
        }
    }
}
