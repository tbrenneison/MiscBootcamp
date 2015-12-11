using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moarLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //m to the power of n 
            //Console.WriteLine("Enter a number.");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("To the power of?");
            //int m = int.Parse(Console.ReadLine());

            //int result = 1; //initialize result

            //for(int i = 0; i < m; i++)
            //{
            //    result *= n;
            //}

            //Console.WriteLine(result); 


            Console.WriteLine("Enter a number.");
            int n = int.Parse(Console.ReadLine());
            int sum = 0; 

            for(int i = 0; i <= n; i+=2)
            {
                if(i % 6 == 0)
                { continue;  }
                sum += i; 
            }
            Console.WriteLine(sum); 
        }
    }
}
