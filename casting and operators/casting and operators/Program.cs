using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casting_and_operators
{
    class Program
    {
        // Subroutine to demonstrate casting and operators
        static void MathsDemo(double X, double Y)
        {
            double DivisionResult = X / Y;
            Console.WriteLine("{0} divided by {1} is {2}", X, Y, DivisionResult);
            int IntDivisionResult = Convert.ToInt32(X / Y);
            Console.WriteLine("{0} integer division by {1} is {2}", X, Y, IntDivisionResult);
            int ModResult = Convert.ToInt32(X % Y);
            Console.WriteLine("{0} modulus {1} is {2}", X, Y, ModResult);
            double OldX = X;
            X++;
            Console.WriteLine("{0} incremented is {1}", OldX, X);
        }

        //Main program
        static void Main(string[] args)
        {
            MathsDemo(10, 7);
            Console.ReadLine();
        }
    }
}
