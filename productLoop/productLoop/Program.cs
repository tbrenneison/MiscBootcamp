using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number.");
            int m = int.Parse(Console.ReadLine());

            int higher;
            int lower;

            if (n > m)
                {
                higher = n;
                lower = m; 
                }
            else
                {
                higher = m;
                lower = n;
                }

            // how do i math lol wut r numberz

            long productOf = 1;

            do
            {
                productOf *= lower;
                Console.WriteLine(productOf);
                lower++;
            } while (lower <= higher);

            Console.WriteLine(productOf); 

        }
    }
}
