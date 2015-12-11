using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElsePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 3;

            if(x <= y)
            { Console.WriteLine("{0} is less than or equal to {1}", x, y); }

            else
            { Console.WriteLine("{0} is NOT less than or equal to {1}", x, y); }
        }
    }
}
