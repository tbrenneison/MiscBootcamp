using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            //STRING.LENGTH 
            string s = "Hello";
            int length = s.Length; //string length
        
            for(int i = 0; i < length; i++) //loops over each character in the string and writes it to the console
                {
                Console.WriteLine(s[i]);
                }


            //FOREACH LOOP OVER EACH CHARACTER IN A STRING 
            Console.WriteLine("Name?");
            string s = Console.ReadLine();

            foreach (char c in s)
                {
                Console.WriteLine(c);
                }

            //

            //ESCAPING SPECIAL CHARACTERS
             Console.WriteLine("\a" + "\"Going Postal\"");
             Console.Write("\t" + "Tori" + "\n" + "Brenneison");

            //
             
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("What is your age?");
            string age = System.Console.ReadLine();
            System.Console.Write("Your name is " + name + "...\n...and you are " + age + " years old.");
            System.Console.WriteLine();  

            //

            //STRINGCOMPARISON.CURRENTCULTUREIGNORECASE
            string word1 = "Hello";
            string word2 = "hello";
            bool strEq = word1 == word2; // ==
            bool strEq2 = (word1.Equals(word2, StringComparison.CurrentCultureIgnoreCase));  // .Equals() w/ ignore case method
            Console.WriteLine(strEq);
            Console.WriteLine(strEq2); 
            
            //

            //COMPARETO METHOD 
            string a = "a";
            string b = "b";
            string bCap = "B";
            string sent = "I like duck.";
            string sentPlural = "I like ducks.";

            Console.WriteLine(a.CompareTo(b)); // compare a and b, result -1
            Console.WriteLine(b.CompareTo(bCap)); //compare b and B, result -1
            Console.WriteLine(sent.CompareTo(sentPlural)); //compare sentence with plural 

            //

            
            //COMPARETO METHOD
            string friend1 = "Natalie";
            string friend2 = "Hannah";
            Console.WriteLine(friend1.CompareTo(friend2));
            Console.WriteLine();
            Console.WriteLine("Dave".CompareTo("Alexandra")); // positiv
            Console.WriteLine("Arturo".CompareTo("Kat")); // negativ

            //

            //STRING CONCATENTATION WITH .Concat 
            string firstName = "John";
            string lastName = "Smith";
            string fullName = string.Concat(firstName, " ", lastName);

            int age = 28;
            string nameAndAge = "Name: " + fullName + "\nAge: " + age;

            Console.WriteLine(nameAndAge);
            
            //

            

            //CASE INSENSITIVE SEARCH FOR ALL OCCURRENCES OF A SUBSTRING 
            string str = "Hello world!  I like to " + "say hello to all my friends.";
            str = str.ToUpper(); //change case to UPPERCASE WHOA 

            string search = "HELLO"; //search for this 
            int position = str.IndexOf(search); // position counter = str.IndexOf("HELLO")
            while (position != -1) // while position is not -1 ...
            {
                Console.WriteLine(search + " found at " + position); // "HELLO" found at position
                position = str.IndexOf(search, position + 1); // position counter sets to start searching at next index 
            }

             
            //SUBSTRING METHOD - return a portion of a string based on starting index and substring length
            string myStr = "We Can Code IT";
            string code = myStr.Substring(7, 4);
            Console.WriteLine(myStr);
            Console.WriteLine(code);

            string path = "C:\\Docs\\MyImage.jpg";
            int index = path.LastIndexOf("\\"); //find last index of backslash 
            string justName = path.Substring(index + 1); //index + 1 to not include the backslash
            Console.WriteLine(justName); //prints just the file name 

            string file = "C:\\Docs\\MyImage.jpg";
            int slashIndex = file.LastIndexOf("\\"); // = index of last backslash
            int dotIndex = file.LastIndexOf(".");  // = index of last dot
            int length = dotIndex - (slashIndex + 1); // find length of substring (slashIndex + 1 to move past backslash)
            string justFileName = file.Substring(slashIndex + 1, length); 
            Console.WriteLine(justFileName);
            Console.WriteLine(file.Substring(slashIndex + 1, length)); //you don't really need justFileName

            //SPLIT METHOD

            string myStr = "We, Can, {Code}, IT";
            char[] separators = new char[] { ',', ' ' };
            string[] splitString = myStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                //.REMOVEEMPTYENTRIES removes the additional array items ' ' caused by the comma
                //   and the space delimiters being next to each other in the source string. 
            foreach(string item in splitString)
                {
                Console.WriteLine(item);
                }

            string line = "3 5 10";
            string[] splitLine = line.Split();
            Console.WriteLine(splitLine[0]);
            Console.WriteLine(splitLine[1]);
            Console.WriteLine(splitLine[2]);
            int[] nums = new int[splitLine.Length];
            for(int i = 0; i <= splitLine.Length -1; i++) //parse them all to ints 
                 {
                nums[i] = int.Parse(splitLine[i]);
                 }
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]); 

    */

            //REPLACE METHOD - replace all instances of a word in a string 
            string myStr = "We Can Code IT";
            string result = myStr.Replace("We", "I"); //replaces all instances of "We" with "I"
            Console.WriteLine(result);




        }
    }
}