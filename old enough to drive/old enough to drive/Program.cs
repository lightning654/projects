using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace old_enough_to_drive
{
    class Program
    {
        // Subroutine to return eligibility to drive
        static void CheckAge(int Age)
        {
            if (Age >= 17)
            {
                Console.WriteLine("You are old enough to learn to drive a car.");
            }
            else
            {
                Console.WriteLine("You are not old enough to learn to drive a car.");
            }
        }

        //Main program
        static void Main(string[] args)
        {
            CheckAge(14);
            Console.ReadLine();
        }
    }
}

