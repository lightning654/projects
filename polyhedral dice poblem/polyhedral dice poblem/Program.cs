using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyhedral_dice_poblem
{
    class Program
    {
        static int RollDice(int faces)
        {
            
            Random Number = new Random();
            return Number.Next(1, (faces +1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of faces on the dice:");
            int faces = Convert.ToInt32(Console.ReadLine());
            faces = RollDice(faces);
            Console.WriteLine("Rolled a {0}", faces);
            Console.ReadLine();
        }
    }
}
