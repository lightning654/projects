using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outputs_string_10_times
{
    class Program
    {
        // Subroutine to demonstrate loops
        static void OutputMessage(string Message)
        {
            for (int Counter = 0; Counter < 10; Counter++)
            {
                Console.WriteLine(Message);
            }
        }

        //Main program
        static void Main(string[] args)
        {
            string Message = "This is how you get code to repeat.";
            OutputMessage(Message);
            Console.ReadLine();
        }
    }
}

