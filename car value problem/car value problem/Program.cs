using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_value_problem
{
    class Program
    {
        static void Compound(int YearC, double valueofcar, double minresale)
        {

            
            

            Console.WriteLine("{0}: {1}", YearC, valueofcar);

            
            
            
                
                for (int counter = 0; counter <= 1; counter++)
                {
                    double depreciation = 0.3;
                    YearC++;
                    valueofcar -= valueofcar * depreciation;
                    Console.WriteLine("{0}: {1}", YearC, valueofcar);
                    
                }

                
                while (valueofcar > minresale)
                {
                    double newint = 0.2;
                    YearC++;
                    valueofcar -= valueofcar * newint;
                if (valueofcar < minresale)
                    break;
                    Console.WriteLine("{0}: {1}", YearC, valueofcar);
                    
                }
                
               
            
            

        }

        static void Main(string[] args)
        {
            Compound(2020,12500,2000);
            Console.ReadLine();
        }
    }
}