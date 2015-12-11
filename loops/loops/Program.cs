using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHILE LOOP 
            //int counter = 0;
            //while(counter <= 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}

            //int sum = 0;
            //int counter = 1;
            //while (counter <= 10)
            //{
            //    sum += counter++;
            //}
            //Console.WriteLine(sum);

            Console.WriteLine("Enter a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a different number.");
            int y = Convert.ToInt32(Console.ReadLine());

            int higher;
            int lower; 

            if ( x > y)
                 {
                higher = x;
                lower = y;
                 }

            else
                 {
                higher = y;
                lower = x;
                 }

            Console.WriteLine(""); // unnecessary; making the output easier to read 

            while(lower <= higher )
                 {
                Console.WriteLine(lower);
                lower++;
                 }


        }



    }
}
