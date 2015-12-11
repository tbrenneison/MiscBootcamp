using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weirdMathProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x / 100;
            Console.WriteLine((y % 10 == 7) ? "equal to seven" : "not equal to seven");

        }
    }
}
