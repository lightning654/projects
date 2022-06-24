using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace username_problem
{
    class Program
    {
        static void username()
        {
            string name;
            string birth;
            string year;
            Console.WriteLine("Enter your full name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth in the format dd/mm/yyyy");
            birth = Console.ReadLine();

            name = name.ToLower();
            name = name.Replace(" ", string.Empty);

            year = birth.Substring(6);

            Console.WriteLine("The suggested usernames are: " + name + year + " , " + name + "_1");
            
            
        }
        static void Main(string[] args)
        {
            username();
            Console.ReadLine();
        }
    }
}
