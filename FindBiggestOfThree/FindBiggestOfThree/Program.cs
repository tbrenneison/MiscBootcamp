using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a third number.");
            int c = Convert.ToInt32(Console.ReadLine()); 

            if((a> b) && (a> c))
            {
                Console.WriteLine(a + " is the biggest number.");

            }
            else
            {
                if ((b > a) && (b > c))
                {
                    Console.WriteLine(b + " is the biggest number."); 
                }
                else
                {
                    Console.WriteLine(c + "is the biggest number."); 
                }
            }
        }
    }
}
