using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fish_tank_volume_problem
{
    class Program
    {
        //subroutine to calculate the volume of the fish tank
        static double volume(double length, double height, double depth)
        {
            return (length * height * depth) / 1000;
        }
        static void Main(string[] args)
        {
            double length = 200; //cm
            double height = 150; //cm
            double depth = 100; //cm
            double tank = volume(length, height, depth);
            Console.WriteLine("the volume of the fish tank is " +tank+  " litres");
            Console.ReadLine();
        }
    }
}
