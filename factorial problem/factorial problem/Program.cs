using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_problem
{
    internal class Program
    {
        static void Main()
        {
            int a = 7;
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
                fact *= x;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
