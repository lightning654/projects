using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpet_cost_problem
{
    class Program
    {
        static double total(double width, double length, double price, double standard, double underlay)
        {
            return ((width * length) * price) + standard +underlay;
        }

        static void Main(string[] args)
        {
            double width = 7; //metres
            double length = 6; //metres
            double price = 17; //price of carpet per m squared
            double standard = ((length * 2) + (width * 2)) + 50;


            double underlay = 3 * (length * width); //pounds
            Console.WriteLine("the total price of the carpet is £" + total(width, length, price, standard, underlay));
            Console.ReadLine();
        }
    }
}
