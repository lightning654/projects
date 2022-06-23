using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatenates_two_strings___Uppercase
{
    class Program
    {
        // Subroutine to concat name
        static string FullName(string String1, string String2)
        {
            return String1.ToUpper() + " " + String2.ToUpper();
        }

        //Main program
        static void Main(string[] args)
        {
            string Forename = "Mohammed";
            string Surname = "Vali";
            string Student = FullName(Forename, Surname);
            Console.WriteLine("Full name: {0}", Student);
            Console.ReadLine();
        }
    }
}

