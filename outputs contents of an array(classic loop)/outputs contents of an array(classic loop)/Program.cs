using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outputs_contents_of_an_array_classic_loop_
{
    class Program
    {
        // Function to output the contents of an array
        static void OutputArray(string[] Sentence)
        {
            string Word;
            for (int Index = 0; Index < Sentence.Length; Index++)
            {
                Word = Sentence[Index];
                Console.WriteLine("Word {0} is {1}.", Index, Word);
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

