using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace driving_test_problem
{
    class Program
    {
        //subroutine to output pass or fail for driving test
        static string PassFail(int MinorFaults)
        {
            if (MinorFaults < 16)
            {
                return "fail";
            }
               
            else
            {
                return "pass";
            }

            
        }

        //main program
        static void Main(string[] args)
        {
            Console.WriteLine(PassFail(15));
            Console.ReadLine();
        }
    }
}
