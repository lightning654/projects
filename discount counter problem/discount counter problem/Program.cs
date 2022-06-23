using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discount_counter_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double start = 10;
            Console.WriteLine("{0}% off", start);
            Random rand = new Random();
            while (start != 60)
            {
                
                double number = rand.Next(1, 10);
                start = start + number;
                Console.WriteLine("{0}% off", start);
                
            }

            Console.ReadLine();


        }
    }
}
