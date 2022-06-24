using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_problem
{
    class Program
    {
        static void isprime(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(num1 + " is a prime number");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            isprime(num1);
            Console.ReadLine();
        }
    }
}
