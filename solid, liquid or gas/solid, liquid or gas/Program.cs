using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid__liquid_or_gas
{
    class Program

    {
        static string State(double temp)
        {
            if (temp >= 100)
            {
                return "gaseous";
            }
            else if (temp >= 1 && temp<=99)
            {
                return "liquid";
            }
            else
            {
                return "solid";
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(State(0));
            Console.ReadLine();
        }
    }
}
