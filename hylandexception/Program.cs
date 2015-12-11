using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylandTryCatchFinally
{
    class Program
    {
        // what will this print out?
        static void Main(string[] args)
        {
            System.Console.WriteLine(new Program().Foo()); //why "new Program().Foo()"? Research this construct -- constructing new object in same class and chaining Foo method. Unusual and simply tricky.
            System.Console.ReadLine();
        }
        String Foo()
        {
            try
            {
                throw new System.Exception ("A Better Exception Message");
                System.Console.Write("Inside Try");
            }
            catch (System.Exception ex)
            {
                return "HERE - " + ex.Message + " yep.";
            }
          /* finally
            {
                System.Console.Write("Finally -- this is the last bit in the try/catch/finally statement");
            } */
            return "Outside Try";

        }
    }
}
