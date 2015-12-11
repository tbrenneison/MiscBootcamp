using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle test = new Triangle(12,8,48);

            Console.WriteLine(test.GetArea()); 
        }
    }

}
