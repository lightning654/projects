using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quote_of_the_day_problem
{
    class Program
    {
        
        // Initialise data
        static string[,] Quote = new string[3, 2];
        static void NewDatabase()
        {
            Quote[1, 0] = "Code is like humour. When you have to explain it, it’s bad.";
            Quote[1, 1] = "Cory House";
            Quote[0, 0] = "Any fool can write code that a computer can understand. Good programmers write code that humans can understand.";
            Quote[0, 1] = "Martin Fowler";
            Quote[2, 0] = "Simplicity is the soul of efficiency.";
            Quote[2, 1] = "Austin Freeman";
        }
        

        // Function to output a random quote
        static (string, string) RandomQuote()
        {
            // Pick a random quote
            Random Number = new Random();
            int Index = Number.Next(0, 3);
            return (Quote[Index, 0], Quote[Index, 1]);
        }
        

        // Main program
        static void Main(string[] args)
        {
            NewDatabase();
            (string Quote, string Author) = RandomQuote();
            Console.WriteLine("{0} - {1}", Quote, Author);
            Console.ReadLine();
        }
    }
}



