using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rolls_a_dice_unti_6_is_thrown
{
    class Program
    {
        // Subroutine to roll a dice until a 6 is rolled
        static int RollSix()
        {
            Random Dice = new Random();
            int Roll = 0;
            int NumberRolls = 0;
            while (Roll != 6)
            {
                Roll = Dice.Next(1, 7);
                NumberRolls++;
            }
            return NumberRolls;
        }

        //Main program
        static void Main(string[] args)
        {
            int Result = RollSix();
            Console.WriteLine("It took {0} rolls of a dice to roll a 6.", Result);
            Console.ReadLine();
        }
    }
}

