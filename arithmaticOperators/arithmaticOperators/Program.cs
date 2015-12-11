using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmaticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int squarePerimeter = 17; // sets squarePerimeter to 17
            double squareSide = squarePerimeter / 4.0; // divides squarePerimeter (17) by four 
            double squareArea = squareSide * squareSide; // multiplies squareSide by squareSide to find the area
            Console.WriteLine(squareSide); //4.25
            Console.WriteLine(squareArea); // 18.0625

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); // adds a and b to make 9 
            Console.WriteLine(a + b++); //adds a and b to make nine and then assigns b a value of 5
            Console.WriteLine(a + b); // adds a and b to make ten 
            Console.WriteLine(a + (++b)); //assigns b a value of six and then adds a and b
            Console.WriteLine(a + b); //adds a and b to make eleven 

            Console.WriteLine(11 / 3); // returns 3 because it does not round and disregards numbers after the decimal point
            Console.WriteLine(11 % 3); //gives remainder of 11 divided by 3, which is 2
            Console.WriteLine(12 / 3); //divides 12 by 3, answer is 4


        }
    }
}
