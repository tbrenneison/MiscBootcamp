using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canYouSeeAnRRatedFilm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
        if(age >= 17)
            {
                Console.WriteLine("You can see the movie.");
            }
        else
            {
                Console.WriteLine("No, you are a baby and we can't let you in.");
            }
                
         }
    }
}
