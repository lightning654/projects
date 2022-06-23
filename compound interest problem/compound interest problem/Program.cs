using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compound_interest_problem
{
    class Program
    {
        static void Compound(double Balance, double InterestRate, double TargetBalance)
        {

            int Year = 0;
            double Interest;

            while (Balance < TargetBalance)
            {
                
                Interest = Balance * InterestRate;
                Balance = Balance + Interest;
                Console.WriteLine("Year {0}: New balance = £{1:0.00}", Year, Balance);
                Year++;
            }
            
        }

        static void Main(string[] args)
        {
            Compound(100, 0.04, 200);
            Console.ReadLine();
        }
    }
}
