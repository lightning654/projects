using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigns_hello_world_to_two_elements
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
            string[] Sentence = new string[2];
            Sentence[0] = "Hello";
            Sentence[1] = "World";
            OutputArray(Sentence);
            Console.ReadLine();
        }
    }
}

