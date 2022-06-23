using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character_problem
{
    class Program
    {
        static string add(string digits, string characters)
        {
            return digits  + " " +  characters;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(add("0123456789",  "abcdABCD@#!£"));
            Console.ReadLine();
        }
    }
}
