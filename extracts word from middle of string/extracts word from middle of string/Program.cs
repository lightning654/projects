using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extracts_word_from_middle_of_string
{
    class Program
    {
        // Subroutine to process a phrase
        static (int, int) Find(string Phrase, string Word)
        {
            int Start = Phrase.IndexOf(Word);
            int End = Start + Word.Length - 1;
            return (Start, End);
        }

        //Main program
        static void Main(string[] args)
        {
            string Phrase = "Code never lies; comments sometimes do. - Ron Jeffries";
            string Word = "comments";
            (int Start, int End) = Find(Phrase, Word);
            Console.WriteLine("'{0}' can be found between characters {1} and {2} in '{3}'.", Word, Start, End, Phrase);
            Console.ReadLine();
        }
    }
}




