using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 0 to 9.");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("badgers");
                    break;
                case 1:
                    Console.WriteLine("narwhals");
                    break;
                case 2:
                    Console.WriteLine("polar bears");
                    break;
                case 3:
                    Console.WriteLine("scorpions");
                    break;
                case 4:
                    Console.WriteLine("fox");
                    break;
                case 5:
                    Console.WriteLine("goat");
                    break;
                case 6:
                    Console.WriteLine("sheepdog");
                    break;
                case 7:
                    Console.WriteLine("jackalope");
                    break;
                case 8:
                    Console.WriteLine("dolphin");
                    break;
                case 9:
                    Console.WriteLine("racoon");
                    break;
            }


            

        }
    }
}
