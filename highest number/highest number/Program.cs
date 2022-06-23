using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highest_number
{
    class Program
    {
        static int GetMax(int first, int second)
        {
            if (first < second)
            {
                return second;
            }
           
            else
            {
                return first;
            }
        }
        static void Main(string[] args)
        {
            int first;
            int second;
            int large;
            Console.WriteLine("Enter first number : ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            second = Convert.ToInt32(Console.ReadLine());
            large = GetMax(first, second);
            Console.WriteLine("the larger of the two numbers is " + large);
            Console.ReadLine();
        }
    }
}
