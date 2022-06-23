using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours_in_a_day_problem
{
    class Program
    {
        static int days(int hours)
        {
            return (hours / 24);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of hours:");
            int hours = Convert.ToInt32(Console.ReadLine());
            hours = days(hours);
            Console.WriteLine(hours);
            Console.ReadLine();
        }
    }
}
