using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checks_a_user_input_against_a_dice_roll
{
    class Program
    {
        // Function to return an input as an integer
        static int GetInput()
        {
            Console.WriteLine("What do you think the dice roll will be? ");
            string Choice = " ";
            bool ValidChoice = false;
            while (!ValidChoice)
            {
                Console.WriteLine("Enter a guess: ");
                Choice = Console.ReadLine();
                if (char.IsNumber(Convert.ToChar(Choice)) == true)
                {
                    ValidChoice = true;
                }
                if (!ValidChoice)
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            return Convert.ToInt32(Choice);
        }
        //Main program
        static void Main(string[] args)
        {
            Random Dice = new Random();
            int Roll = Dice.Next(1, 7);
            int Choice = GetInput();
            Console.WriteLine("The roll was {0}, you guessed {1}", Roll, Choice);
            Console.ReadLine();
        }
    }
}

