using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageAndHeightAllowance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your age.");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your height in feet, using a decimal.");
            double height = Convert.ToDouble(Console.ReadLine());

            if ((age >= 18) && (height >= 5.0))
            {
                Console.WriteLine("You're okay.");
            }
            else
            {
                Console.WriteLine("You are too young or too short or both.");
            }

        }
    }
}
