using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_charatcters_in_a_string
{
    class Program
    {
        // Subroutine to count characters
        static void ShowLen(string Surname)
        {
            int StringLength = Surname.Length;
            Console.WriteLine("There are {0} letters in your surname, {1}.", StringLength, Surname);
        }

        //Main program
        static void Main(string[] args)
        {
            string Surname = "Zain";
            ShowLen(Surname);
            Console.ReadLine();
        }
    }
}

