using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changes_elements_and_outputs_array
{
    class Program
    {
        // Function to output the contents of an array
        static void OutputArray(string[] Sentence)
        {
            foreach (string Word in Sentence)
            {
                Console.Write(Word + " ");
            }
            Console.WriteLine();
        }

        //Main program
        static void Main(string[] args)
        {
            string[] Sentence = { "The", "quick", "brown", "fox", "jumps" };
            OutputArray(Sentence);
            Sentence[1] = "small";
            Sentence[2] = "grey";
            Sentence[3] = "squirrel";
            OutputArray(Sentence);
            Console.ReadLine();
        }
    }
}

