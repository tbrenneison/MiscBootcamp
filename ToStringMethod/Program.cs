using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 239587234;
            int numbertoadd;
            List<int> digits = new List<int>();
            while (num > 0)
            {
                numbertoadd = num % 10;
                digits.Add(numbertoadd);
                num = num / 10;
            }

            digits.Reverse();

            string str = "";
            foreach (int digit in digits)
            {

                str = str + digit;
            }
        }
    }
}
