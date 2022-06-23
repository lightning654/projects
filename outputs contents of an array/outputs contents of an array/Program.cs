using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outputs_contents_of_an_array
{
    class Program
    {
        // Function to output the contents of an array
        static void OutputArray(string[] Sentence)
        {
            int Index = 0;
            foreach (string Word in Sentence)
            {
                Console.WriteLine("Word {0} is {1}.", Index, Word);
                Index++;
            }
        }

        //Main program
        static void Main(string[] args)
        {
            string[] Sentence = { "The", "quick", "brown", "fox", "jumps" };
            OutputArray(Sentence);
            Console.ReadLine();
        }
    }
}
