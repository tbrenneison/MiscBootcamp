using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areYouAnAdultWhoCanDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can drive and are an adult."); 
            }
            else
            {
                Console.WriteLine("You are not an adult.");
                if (age >= 16)
                {
                    Console.WriteLine("...but you can drive.");
                }
                else
                {
                }
            }

            }
        }
    }

