using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_converter
{
    class Program
    {
        //subroutine to convert centigrade to farenheit 
        static double CtoF(double C)
        {
            return (C * 1.8) + 32;
        }
        //Subroutine to covert farenheit to centigrade
        static double FtoC(double F)
        {
            return (F - 32) / 1.8;
        }

       //main program
        static void Main(string[] args)
        {
            double C = 30;
            double F = CtoF(C);
            Console.WriteLine(C + " degrees C is " + F + " degrees F ");
            Console.ReadLine();
        }
    }
}
