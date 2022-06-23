using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creates_2D_array
{
    class Program
    {
        static string[,] Product = new string[4, 2];

        // Subroutine to put data into the array
        static void NewDatabase()
        {
            Product[0, 0] = "Cornflakes"; Product[0, 1] = "1.40";
            Product[1, 0] = "Weetabix"; Product[1, 1] = "1.20";
        }

        // Subroutine to output a product from the array
        static void OutputProduct(int Number)
        {
            Console.WriteLine("{0}: £{1:0.00}", Product[Number, 0], Product[Number, 1]);
        }

        //Main program
        static void Main(string[] args)
        {
            NewDatabase();
            OutputProduct(1);
            Console.ReadLine();
        }
    }
}

