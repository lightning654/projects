using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Separator
{
    class Program
    {
        static void FullName(string name)
        {
           



            string[] subs = name.Split(' ');



            foreach (var sub in subs)

            {

                Console.WriteLine(sub);

            }


        }
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What is your full name?");
            name = Console.ReadLine();
            FullName(name);
            Console.ReadLine();
        }
    }
}
