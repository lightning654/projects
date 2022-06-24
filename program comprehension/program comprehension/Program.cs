using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_comprehension
{
    class Program
    {
        static double Sq(double X)
        {
            return X * X;
        }

        static void Main(string[] args)
        {
            int A = 9;
            Console.WriteLine(A + " squared: " + Sq(A));
            Console.ReadLine();
        }
    }
}
