using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number_problem
{
    class Program
    {
        // Function to return valid input
        static int GetInput()
        {
            bool ValidInput = false;
            string Number;
            int INumber = 0;

            while (!ValidInput)
            {
                Console.Write("Enter a number: ");
                Number = Console.ReadLine();
                if (int.TryParse(Number, out INumber))
                {
                    ValidInput = true;
                }

            }

            return (INumber);
        }
        

        // Subroutine to play guess the number
        static void GuessTheNumber()
        {
            Random Number = new Random();
            int CPU = Number.Next(1, 101);
            
            int PlayerGuess = 0;
            int GuessCount = 0;
            

            while (PlayerGuess != CPU)
            {
                PlayerGuess = GetInput();
                GuessCount++;
                if (PlayerGuess < CPU)
                {
                    Console.WriteLine("Too low.");
                    

                }
                else if (PlayerGuess > CPU)
                {
                    Console.WriteLine("Too high.");
                    

                }
                
            }
            if (PlayerGuess == CPU)
            {
                Console.WriteLine("You've got it, I chose {0}. It took you {1} guesses.", CPU, GuessCount);

            }
            Console.ReadLine();


        }
        static void Main(string[] args)
        {
            GuessTheNumber();
            Console.ReadLine();
        }
    }
}
