using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x % 2 == 0 ? "even" : "odd"); 
        }
    }
}
