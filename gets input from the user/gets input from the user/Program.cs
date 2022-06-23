using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gets_input_from_the_user
{
    class Program
    {
        // Function to return an input
        static string GetInput()
        {
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Option 3");
            Console.WriteLine("Enter an option number: ");
            string Choice = Console.ReadLine();
            return Choice;
        }

        //Main program
        static void Main(string[] args)
        {
            string Choice = GetInput();
            Console.WriteLine("You chose option {0}.", Choice);
            Console.ReadLine();
        }
    }
}

