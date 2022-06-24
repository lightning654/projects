using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace save_the_change_problem
{
    class Program
    {
        // Subroutine to calculate difference to nearest 1
        static double SaveTheChange(double Amount)
        {
            int NearestPound;
            if (Convert.ToInt32(Amount) != Amount)
            {
                NearestPound = Convert.ToInt32(Amount) + 1;
                
            }
            else
            {
                NearestPound = Convert.ToInt32(Amount);
            }
            return NearestPound - Amount;

        }
        

        static void Main(string[] args)
        {
            
            double Price = 23.25;
            double Savings = SaveTheChange(Price);
            Console.WriteLine("Debit - Purchase: £{0:0.00}", Price);
            Console.WriteLine("Debit - Save the change: £{0:0.00}", Savings);
            Console.WriteLine("Credit - Save the change: £{0:0.00}", Savings);
            Console.ReadLine();
        }
    }
}
