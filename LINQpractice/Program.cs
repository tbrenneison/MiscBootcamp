using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intz = { 7,2,5,8,245,623,42,35,2 };

            IEnumerable<int> intQuery = from num in intz where num > 6 select num; 

            foreach(int number in intQuery)
            {
                Console.WriteLine(number); 
            }

        }
    }
}
