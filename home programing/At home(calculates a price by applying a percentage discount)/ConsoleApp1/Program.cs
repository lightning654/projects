using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Subroutine to calculate price
        static double Discount(double Total, double Rate)
        {
            return Total - (Total * Rate / 100);
        }

        //Main program
        static void Main(string[] args)
        {
            Console.WriteLine(Discount(60, 50));
            Console.ReadLine();        }
    }
}
