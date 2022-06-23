using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculates_least_common_denominator
{
    class Program
    {
        // Subroutine to use trial and error to calculate LCD
        static int LCM(int Number1, int Number2)
        {
            int Counter = 1;
            while ((Counter % Number1 != 0) || (Counter % Number2 != 0))
            {
                Counter++;
            }
            return Counter;
        }

        //Main program
        static void Main(string[] args)
        {
            int Number1 = 20;
            int Number2 = 7;
            int Result = LCM(Number1, Number2);
            Console.WriteLine("The LCM of {0} and {1} is {2}", Number1, Number2, Result);
            Console.ReadLine();
        }
    }
}

