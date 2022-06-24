using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randon_number_between_1_and_6
{
    class Program
    {
        // Subroutine to generate a random number
        static int RollDice()
        {
            Random Number = new Random();
            return Number.Next(1, 7);
        }

        //Main program
        static void Main(string[] args)
        {
            int Dice = RollDice();
            Console.WriteLine("Rolled a {0}", Dice);
            Console.ReadLine();
        }
    }
}
