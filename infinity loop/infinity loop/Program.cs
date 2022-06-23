using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infinity_loop
{
    class Program
    {
        // Infinite loop
        static int ToInfinity()
        {
            while (true)
            {
                Console.WriteLine("To infinity and beyond...");
            }
        }

        //Main program
        static void Main(string[] args)
        {
            ToInfinity();
        }
    }
}

