using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> birthYears = new List<int>() { 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1993, 1994, 1995, 1996 };

            List<int> ages = new List<int>();
            ages.Add(29);
            ages.Add(28);
            ages.Add(27);
            ages.Add(26);
            ages.Add(25);
            ages.Add(24);
            ages.Add(23);
            ages.Add(22);
            ages.Add(21);
            ages.Add(20);
            ages.Add(19);

          foreach (int age in ages)
               {
               Console.WriteLine(age);
               }
           Console.WriteLine();
           */

            /*
            List<string> names = new List<string>() { "Kate", "David", "Benjamin", "Ryan", "Flora" };

            names.Add("Melissa");
            names.Add("Stephanie");
            names.Add("Gregory");
            names.Add("William");
            names.Add("Elizabeth");
            */

            /* AN EXPERIMENT
            Console.WriteLine("Would you like to add more names?  Y/N");
            string answer = Console.ReadLine().ToUpper();
 
            if (answer == "Y")
            {
                
                Console.WriteLine("Enter student names.  Enter 'exit' to quit.");
                string input = "";
                while (input != "exit")
                {
                    input = Console.ReadLine();
                    if (input == "exit")
                    {
                        break;
                    }
                    names.Add(input);    
                }
            }
             */

            /* WIPE OUT THE LIST
            Console.WriteLine(names.Count);
            names.Clear();
            Console.WriteLine(names.Count); 
            */

            /*
            StreamWriter writer = new StreamWriter("..\\..\\students.txt", true); //write student names to file 
                 using(writer)
             {
                 writer.WriteLine("Students:\r\n");
                 foreach(string name in names)
                      {
                     writer.WriteLine(name); 
                      }
             }
             */

            //COPY ARRAY TO LIST 
            string[] names = { "Sandra", "Luke", "Robin", };

            List<string> nameList = names.ToList();  //using LINQ to convert array to list
            string[] convertedList = nameList.ToArray(); //convert list to array 

            //these should have the same output
            foreach (string name in nameList)
            {
                Console.WriteLine(name); 
            }
            Console.WriteLine(); //empty line to separate 
            foreach(string name in convertedList)
            {
                Console.WriteLine(name); 
            }

        }
    }
}
