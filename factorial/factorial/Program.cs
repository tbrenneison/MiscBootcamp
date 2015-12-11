using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1; //decimal is the largest data type which can hold an integer

            do
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            } while (true);

            Console.WriteLine("n! = " + factorial);
            
            //end 
        }


    }
}
