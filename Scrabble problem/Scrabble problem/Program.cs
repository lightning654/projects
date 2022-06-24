using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble_problem
{
    class Program
    {
        static int points(string word)
        {
            int score = 0;
            foreach (char letter in word)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'n':
                    case 'r':
                    case 't':
                    case 'l':
                    case 's':
                    case 'u':
                        score += 1;
                        break;
                    case 'g':
                    case 'd':
                        score += 2;
                        break;
                    case 'b':
                    case 'c':
                    case 'm':
                    case 'p':
                        score += 3;
                        break;
                    case 'f':
                    case 'h':
                    case 'v':
                    case 'w':
                    case 'y':
                        score += 4;
                        break;
                    case 'k':
                        score += 5;
                        break;
                    case 'j':
                    case 'x':
                        score += 8;
                        break;
                    case 'q':
                    case 'z':
                        score += 10;
                        break;

                }
            }
            return score;
        }
        static void Main(string[] args)
        {
            string word = "";
            Console.WriteLine("Enter a word");
            word = Console.ReadLine();
            Console.WriteLine(points(word));
            Console.ReadLine();
        }
    }
}
