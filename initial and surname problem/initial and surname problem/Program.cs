using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initial_and_surname_problem
{
    class Program
    {
        static string FormatName(string first, string second)
        {
            first = first.ToUpper();
            second = second.ToUpper();
            return (first +" "+ second);
        }
        static void Main(string[] args)
        {
            string first = "";
            string second = "";
            Console.WriteLine("What is your first name?");
            first = Console.ReadLine();
            Console.WriteLine("What is your second name?");
            second = Console.ReadLine();
            Console.WriteLine(FormatName(first, second));
            Console.ReadLine();
        }
    }
}
