using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_problem
{
    class Program
    {
        static string exists(string invent, string check)
        {
            check = char.ToUpper(check[0]) + check.Substring(1);
            if (invent.Contains(check))
            {
                return ("it is in your inventory");
            }
            else
            {
                return ("it is not in your inventory");
            }
        }
        static void Main(string[] args)
        {
            string check = "";
            string invent = "Sword, Shield, Potion, Amulet";
            Console.WriteLine("What do you want to check?");
            check = Console.ReadLine();
            string answer = exists(invent, check);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
