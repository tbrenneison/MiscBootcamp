using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstandlastname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("\n"); //making this easier to read in the console 
            Console.WriteLine("Hello, {0}!\n", firstName);
            //concatenation
            Console.WriteLine("Your full name is " + firstName + " " + lastName + ".");
            //new string variable
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Your full name is {0}.", fullName); 
            
        
        }
    }
}
