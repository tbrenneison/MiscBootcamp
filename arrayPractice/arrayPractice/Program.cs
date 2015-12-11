using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string[]daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Caturday", "Sunday" };

            // char[] lastName = {'B','R','E','N','N','E','I','S','O','N' };
            // Console.WriteLine(lastName.Length);

            // string[] stringArray = { "cat", "dog", "tortoise", "unicorn", "honey badger"};
            // string secondToLast = stringArray[((stringArray.Length) - 2)];
            // Console.WriteLine(secondToLast);

            //   int[] studentAges = new int[3];
            //   studentAges[0] = 14;
            //   studentAges[1] = 15;
            //   studentAges[2] = 8;

            //   if((studentAges[0] < studentAges[1]) && (studentAges[0] < studentAges[2]))
            //   {
            //       Console.WriteLine("The youngest student is " + studentAges[0]);
            //   }

            //   else
            //   {
            //       if((studentAges[1] < studentAges[0]) && (studentAges[1] < studentAges[2]))
            //       {
            //           Console.WriteLine("The youngest student is " + studentAges[1]);
            //       }
            //       else
            //       {
            //           Console.WriteLine("The youngest student is " + studentAges[2]);
            //       }
            //    }

            // string[] birthMonths = { "October", "July", "October", "May" };
            // Console.WriteLine(Array.IndexOf(birthMonths, "October"));  //returns 0
            //Array.IndexOf returns the first index that matches a specified value

            // string[] firstNames = { "Amanda", "David", "Jean", "Frank", "David" };
            // Console.WriteLine(Array.LastIndexOf(firstNames, "David"));

            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Array.Reverse(numbers); //reverses order of the array
            //Console.WriteLine(numbers[0]); //returns 5

            // char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h','i', 'j', 'k', 'l', 'm', 'n','o','p','q','r','s','t','u','v','w','x','y','z' };
            // Console.WriteLine(alphabet[0]);
            // Array.Reverse(alphabet);
            // Console.WriteLine(alphabet[0]);

            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Array.Sort(numbers);
            //Console.WriteLine("{0} {1} {2} {3} {4} {5}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5]);

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Caturday", "Sunday" };
            int i;
            for (i = 0; i < days.Length; i++)
            {
                Console.WriteLine("Today is " + days[i]);
            }
        }
    }
}
