using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;


namespace key_stage_using_breaks
{
    class Program
    {
        // Subroutine to output Key Stage
        static void YearGroup(int Year)
        {
            switch (Year)
            {
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Key Stage 3");
                    break;
                case 10:
                case 11:
                    Console.WriteLine("Key Stage 4");
                    break;
            }
        }

        //Main program
        static void Main(string[] args)
        {
            YearGroup(8);
            Console.ReadLine();
        }
    }
}
