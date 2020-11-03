using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseNumber();
        }

        static void ReverseNumber()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                string s = Console.ReadLine();
                Console.Write("The reverse number is: ");
                char[] num = s.ToCharArray();

                for (int i = num.Length - 1; i >= 0; i--)
                {
                    Console.Write(num[i]);
                }

                Console.WriteLine("\n");
            }
        }
    }
}
