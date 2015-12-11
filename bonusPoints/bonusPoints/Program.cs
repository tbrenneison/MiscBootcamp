using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your score?");
            int score = Convert.ToInt32(Console.ReadLine());
            if ((score >= 1) && (score <= 3))
            { Console.WriteLine(score * 10); }
            else if ((score >= 4) && (score <= 6))
            { Console.WriteLine(score * 100); }
            else if ((score >=7) && (score <= 9))
            { Console.WriteLine(score * 1000); }
            else
            { Console.WriteLine("Error"); }

        }
    }
}
