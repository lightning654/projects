using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_or_odd
{
    class Program
    {
        // Subroutine to return odd or even
        static string OddEven(int Number)
        {
            if (Number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        //Main program
        static void Main(string[] args)
        {
            Console.WriteLine(OddEven(5));
            Console.ReadLine();
        }
    }
}
