using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validates_the_input
{
    class Program
    {
        // Function to return a valid  input
        static string GetInput()
        {
            Console.WriteLine("a. Option A");
            Console.WriteLine("b. Option B");
            bool Valid = false;
            string Choice = "";
            while (!Valid)
            {
                Console.WriteLine("Enter an option: ");
                Choice = Console.ReadLine();
                if ((Choice == "1") || (Choice == "2") || (Choice == "A") || (Choice == "B"))
                {
                    Valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid option chosen. Try again.");
                }
            }
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

