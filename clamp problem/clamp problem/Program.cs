using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clamp_problem
{
    class Program
    {
        static int Clamp(int number, int max)
        {
            if (number > max)
            {
                number = max;
            }

            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Clamp(80, 50));
            Console.ReadLine();
        }
    }
}
