using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetable_problem
{
    class Program
    {

        static void TimesTable(int X)
        {
            for (int Counter = 1; Counter < 13; Counter++)
                Console.WriteLine("{0} x {1} = {2}", Counter, X, Counter * X);
        }
        static void Main(string[] args)
        {
            TimesTable(10);
            Console.ReadLine();
        }
    }
}
