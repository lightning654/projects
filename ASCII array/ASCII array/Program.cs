using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_array
{
    class Program
    {
        static char[,] Grid = new char[5, 5];

        static void NewGrid()
        {
            char Letter;
            int ASCII;
            Random Pick = new Random();
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 5; X++)
                {
                    ASCII = Pick.Next(1, 26) + 64;
                    Letter = (char)ASCII;
                    Grid[X, Y] = Letter;
                }
                Console.WriteLine(Grid);
            }
        }

        static void Main(string[] args)
        {
            NewGrid();
            Console.ReadLine();
        }
    }
}

