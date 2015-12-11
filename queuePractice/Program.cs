using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queuePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Queue <string> firstQ = new Queue<string>();
            firstQ.Enqueue("first");
            firstQ.Enqueue("second");
            firstQ.Enqueue("third"); 
            */

            Queue<string> ponies = new Queue<string>();
                ponies.Enqueue("Princess Twilight Sparkle");
                ponies.Enqueue("Applejack");
                ponies.Enqueue("Pinkie Pie");
                ponies.Enqueue("Rarity");
                ponies.Enqueue("Fluttershy");
                ponies.Enqueue("Rainbow Dash");
                ponies.Enqueue("Princess Celestia");
                ponies.Enqueue("Princess Luna");
                ponies.Enqueue("Princess Cadance");
                ponies.Enqueue("Sunset Shimmer");
                ponies.Enqueue("Doctor Hooves");
                ponies.Enqueue("Muffins");  

            foreach(string pony in ponies)
                {
                Console.WriteLine(pony);
                }






        }
    }
}