using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Problem
{
    class Program
    {
        // Function to provide a currency conversion
        static double Exchange(double Pounds, string Currency)
        {
            double Money = 0;
            if (Currency == "USD")
            {
                Money = Pounds * 1.3;
            }
            else if (Currency == "Euro")
            {
                Money = Pounds * 1.11;
            }
            else if (Currency == "Yuan")
            {
                Money = Pounds * 8.92;
            }
            else if (Currency == "Yen")
            {
                Money = Pounds * 138.44;
            }
            return Money;
        }

        // Main program
        static void Main(string[] args)
        {
            double GBP = 100;
            string Currency = "Yen";
            double Money = Exchange(GBP, Currency);
            Console.WriteLine(GBP + " GBP = " + Money + " " + Currency);
            Console.ReadLine();
        }
    }
}
