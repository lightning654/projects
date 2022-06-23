using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowrate
{
    class Program
    {
        // Subroutine to calculate flow rate of the heart
        static double FlowRate(double Volume, double Time)
        {
            return Volume / Time;
        }

        //Main program
        static void Main(string[] args)
        {
            double Volume = 330; //ml
            double Time = 4;     //seconds
            double Heart = FlowRate(Volume, Time);
            Console.WriteLine("The flow rate of the human heart is " + Heart + "ml/s");
            Console.ReadLine();
        }
    }
}

