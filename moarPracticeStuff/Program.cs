using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moarPracticeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\inputfile.txt");
            using (reader)
            {
                string line = reader.ReadLine(); //read first line
                while(line != null)
                {
                    line = reader.ReadLine(); //read next line
                }
            }
        }
    }
}
