using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "EM edit";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
            string caps = ExtractCapitals(text);
            Console.WriteLine(caps);
        }

        public static string ExtractCapitals(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                {
                    result.Append(ch);
                }
            }
            return result.ToString(); 
        }

        static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder(); 
            for (int i = text.Length -1; i >= 0; i--)
                {
                sb.Append(text[i]);
                }
            return sb.ToString();
        }
    }
}
