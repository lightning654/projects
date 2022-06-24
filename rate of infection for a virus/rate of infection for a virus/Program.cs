using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rate_of_infection_for_a_virus
{
    class Program
    {
        // Subroutine to show spread of a virus
        static void ModelVirus(int Day, int CurrentCases, double R, int Target)
        {
            int PopulationInfected = CurrentCases;
            do
            {
                PopulationInfected = Convert.ToInt32(CurrentCases * Math.Pow(2.718, (R * Day)));
                Console.WriteLine("People infected on day {0}: {1}", Day, PopulationInfected);
                Day++;
            }
            while (PopulationInfected < Target);
        }

        //Main program
        static void Main(string[] args)
        {
            // Day 1, Cases 1, R 1.5, Target 10000
            ModelVirus(1, 1, 1.5, 10000);
            Console.ReadLine();
        }
    }
}

