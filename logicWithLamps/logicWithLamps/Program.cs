using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicWithLamps
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lightSwitch = true; //"on"
            bool lamp = true; //"on"

            Console.WriteLine(lightSwitch && lamp); //true (&& both have to be true)
            Console.WriteLine(lightSwitch || lamp); //true (|| one needs to be true)
            Console.WriteLine(!lightSwitch); // false (not is opposite of value)
            Console.WriteLine(lightSwitch ^ lamp); //false (only one of two can be true)


        }
    }
}
