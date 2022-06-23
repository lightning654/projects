using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nitrate_problem
{
    class Program
    {
        static void Nitrate(double x)
        {
            if (x >= 10)
            {
                Console.WriteLine("For " + x + " Nitrate dose 3 ml");
            }
            else if (x>2.5)
            {
                Console.WriteLine("For " + x + " Nitrate dose 2 ml");
            }
            else if (x>=1)
            {
                Console.WriteLine("For " + x + " Nitrate dose 1 ml");
            }
            else if (x<1)
            {
                Console.WriteLine("For " + x + " Nitrate dose 0.5 ml");
            }
        }
        static void Main(string[] args)
        {
            Nitrate(0.7);
            Console.ReadLine();
        }
    }
}
