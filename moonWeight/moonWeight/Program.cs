using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moonWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight on Earth?");
            double earthWeight = Convert.ToDouble(Console.ReadLine());
            double moonWeight = (earthWeight * 0.17);
            Console.WriteLine("Your weight on the moon is... " + moonWeight); 
        }
    }
}
