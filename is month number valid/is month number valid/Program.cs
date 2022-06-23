using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_month_number_valid
{
    class Program
    {
        // Subroutine to validate month
        static void ValidMonth(int Month)
        {
            if (Month > 0 && Month < 13)
            {
                Console.WriteLine("Valid month");
            }
            else
            {
                Console.WriteLine("Invalid month");
            }
        }

        //Main program
        static void Main(string[] args)
        {
            ValidMonth(8);
            Console.ReadLine();
        }
    }
}
