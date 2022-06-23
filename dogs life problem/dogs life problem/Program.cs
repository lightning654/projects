using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogs_life_problem
{
    class Program
    {
        static double Dogage(double a)
        {
            if (a <= 2)
            {
                return 12 * a;
            }
            else if (a>2)
            {
                return ((24 + (6 * a) -2));
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Enter the age of the dog: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The dog is " + Dogage(a) + " in dog age");
            Console.ReadLine();
        }

    }
}
