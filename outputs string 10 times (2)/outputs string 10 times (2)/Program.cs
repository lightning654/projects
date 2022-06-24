using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outputs_string_10_times__2_
{
	class Program
    {
        // Subroutine to demonstrate loops
        static void DemoLoop()
        {
            for (int Counter = 1; Counter < 11; Counter++)
            {
                Console.WriteLine("This is line {0}", Counter);
            }
        }

        //Main program
        static void Main(string[] args)
        {
            DemoLoop();
            Console.ReadLine();
        }
    }
}
