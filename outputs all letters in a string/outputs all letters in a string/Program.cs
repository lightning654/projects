using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outputs_all_letters_in_a_string
{
    internal class Program
    {
        // Subroutine to demonstrate loops
        static void CharLoop(string Message)
        {
            for (int Index = 0; Index < Message.Length; Index++)
            {
                string Alpha = Message.Substring(Index, 1);
                Console.WriteLine("Character {0} of {1} is {2}.", Index, Message, Alpha);
            }
        }

        //Main program
        static void Main(string[] args)
        {
            string Message = "Hello World";
            CharLoop(Message);
            Console.ReadLine();
        }
    }
}

