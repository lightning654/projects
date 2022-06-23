using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_problem
{
    class Program
    {
        static void divisible(int a, int b)
        {
            if (b==0)
            {
                Console.WriteLine("False");
            }
            else if ((b % a) == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            divisible(a, b);
            Console.ReadLine();
        }
    }
}
