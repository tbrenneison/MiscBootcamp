using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Stack<string> newStack = new Stack<string>();
            newStack.Push("first element");
            newStack.Push("second element");
            newStack.Push("third element"); 

            foreach(string s in newStack)
            {
                Console.WriteLine(s); 
            }
            */

            /*
            Stack<int> staack = new Stack<int>();
            staack.Push(1);
            staack.Push(2);
            staack.Push(3);
            staack.Push(4);
            staack.Push(5);

            int lastin = staack.Pop(); //pop 5 off of stack 
            Console.WriteLine(lastin); 

            Console.WriteLine(); 

            foreach(int s in staack) //the 5 went away yay
                {
                Console.WriteLine(s);
                }
            */

            /*
            Stack<string> stringey = new Stack<string>();
            stringey.Push("stringey stringey stringey");
            stringey.Push("I am out of ideas");
            stringey.Push("I get how to make a stack let's move on plz"); 
            */

            /*
            Stack<int> lawls = new Stack<int>(); //I am so tired of making stacks
            lawls.Push(1);
            lawls.Push(2);
            lawls.Push(3);
            lawls.Push(4);
            lawls.Push(5);

            Console.WriteLine("LAWLS has " + lawls.Count + " elements in it."); //count the elements in the stack 
            Console.WriteLine("Does LAWLS contain a 3?");
            Console.WriteLine(lawls.Contains(3)); //does the stack contain this element
            Console.WriteLine("If ^ is TRUE then OMFG YES IT HAS A 3 IN IT.");
            int[] lawls2 = lawls.ToArray();  //copies elements of the stack into an array 
            Console.WriteLine("I'm'a clear out LAWLS.  Now let's print everything in it:");
            lawls.Clear(); //removes all elements in the stack 
            foreach (int i in lawls)
                {
                Console.WriteLine(i);
                }
            Console.WriteLine("Did nothing happen?  SHOCKING.  Almost like that worked.");
            Console.WriteLine("Luckily I copied LAWLS to an array before I did that.");
            Console.WriteLine("lawls2[0] should be a 5.  Is it?"); //FILO wut
            Console.WriteLine(lawls2[0]);
            Console.WriteLine("If ^ is a 5, IT TOTALLY DID.  GASP.");
            */

            /*
            //Write a program, which reads from the console N (any number) integers and prints them in reversed order.
            Stack<string> nums = new Stack<string>();
            Console.WriteLine("Enter numbers one at a time.  Enter 'n' to stop.");
            string enterednum = Console.ReadLine();
            if (enterednum == "N") //make sure that input to stop is 'n'
                {
                enterednum.ToLower();
                }
            while (enterednum != "n")
                 {
                nums.Push(enterednum);
                enterednum = Console.ReadLine(); 
                 }
           
            Console.WriteLine("Now let's print them out in reversed order."); 
            foreach(string num in nums)
                 {
                Console.WriteLine(num);
                 }
            */


        }
    }
}
