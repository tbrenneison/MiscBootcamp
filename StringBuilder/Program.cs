using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringBuilder");
            Console.WriteLine(DateTime.Now); // timestamp

            StringBuilder numSB = new StringBuilder();
            numSB.Append("Build with StringBuilder");

            for (int i = 0; i < 50000; i++)
                 { numSB.Append(i); }

            Console.WriteLine(DateTime.Now); // timestamp 

            Console.WriteLine("String Concatenation");
            Console.WriteLine(DateTime.Now);

            string numStr = "";
            numStr += "Build with concatenation";
            for (int i = 0; i < 50000; i++)
            {
                numStr += i;
            }
            Console.WriteLine(DateTime.Now);

        }
    }
}
