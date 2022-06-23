using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace key_stage
{
    class Program
    {
        // Subroutine to output Key Stage
        static void YearGroup(int Year)
        {
            if (Year >= 7 && Year < 10)
            {
                Console.WriteLine("Key Stage 3");
            }
            else if (Year >= 10 && Year < 12)
            {
                Console.WriteLine("Key Stage 4");
            }
        }

        //Main program
        static void Main(string[] args)
        {
            YearGroup(9);
            Console.ReadLine();
        }
    }
}
