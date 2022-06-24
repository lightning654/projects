using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_calculator
{
    class Program
    {
        // Subroutine to calculate VAT
        static double VAT(double Total)
        {
            return Total * 0.05;
        }

        //Main program
        static void Main(string[] args)
        {
            const double Total = 100.12;
            double ValueAddedTax = VAT(Total);
            double ToPay = Total + ValueAddedTax;
            Console.WriteLine("Total £{0:0.00} :: VAT £{1:0.00} :: To Pay £{2:0.00}", Total, ValueAddedTax, ToPay);
            Console.ReadLine();
        }
    }
}
