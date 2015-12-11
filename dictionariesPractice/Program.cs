using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<string, int> studentScores = new Dictionary<string, int>();
            studentScores.Add("StudentA", 89);
            studentScores.Add("StudentB", 75);
            studentScores.Add("StudentC", 94);
            studentScores.Add("StudentD", 98);

            foreach (KeyValuePair<string, int> student in studentScores)
            {
                Console.WriteLine(student);
            }

            //string = key, int = value 
            Console.WriteLine(studentScores["StudentC"]);  //prints StudentC's score 

            */


            /*
            Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            coatCheck.Add(1, "peacoat");
            coatCheck.Add(2, "trenchcoat");
            coatCheck.Add(3, "moto jacket");
            coatCheck.Add(4, "fleece jacket");
            coatCheck.Add(5, "parka");
            coatCheck.Add(6, "dinner jacket");
            coatCheck.Add(7, "raincoat");
            coatCheck.Add(8, "leather jacket");
            coatCheck.Add(9, "windbreaker");
            coatCheck.Add(10, "hoodie");
            */

            /*
            Dictionary<string, string> valetStation = new Dictionary<string, string>();
            valetStation.Add("Brenneison", "VW");
            valetStation.Add("Baughman", "VW");
            valetStation.Add("Pitzer", "Chevrolet");
            valetStation.Add("McGee", "Audi");
            valetStation.Add("Dickerson", "Nissan");
            valetStation.Add("Gandy", "Kia");
            valetStation.Add("Goerlich", "Chrysler");
            valetStation.Add("Aikins", "Chevrolet");
            valetStation.Add("Peters", "Nissan");
            valetStation.Add("Kotik", "VW");
            valetStation.Add("Moore", "Mercury"); 
            */

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();
            zooAnimals.Add("elephant", 2);
            zooAnimals.Add("tiger", 3);
            zooAnimals.Add("penguin", 3);
            zooAnimals.Add("lion", 2);
            zooAnimals.Add("peacock", 23);
            zooAnimals.Add("pica", 927);
            zooAnimals.Add("grizzly bear", 2);
            zooAnimals.Add("swordfish", 3);
            zooAnimals.Add("red panda", 4);
            zooAnimals.Add("tortoise", 1);

            zooAnimals.Remove("tortoise"); //remove animal of lowest quantity

            Console.WriteLine(zooAnimals.Count()); //count entries 

            Console.WriteLine("Check to see if an animal is in the zoo.  Enter the name of the animal.");
            string animal = Console.ReadLine(); 
            if(zooAnimals.ContainsKey(animal))
            {
                Console.WriteLine("The dictionary has at least one " + animal + "."); 
            }
            else
            {
                Console.WriteLine("The dictionary doesn't have any of those, sorry!");
                Console.WriteLine("Would you like to add it to the dictionary? Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    zooAnimals.Add(animal, 1);
                    if (zooAnimals.ContainsKey(animal))
                    { Console.WriteLine("Now the dictionary has a " + animal + "!"); }
                }
                else
                { Console.WriteLine("Bye Felicia."); }

            }
        }
    }
}
