using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career_quote_problem
{
    class Program
    {
        static void jobtitle(string job)
        {
            if (job=="Engineer")
            {
                Console.WriteLine("The engineer has been, and is, a maker of history.");
            }
            else if (job == "Developer")
            {
                Console.WriteLine("Logical thinking, passion and perseverance is the paint on your palette.");
            }
            else if (job=="Analyst")
            {
                Console.WriteLine("Seeing what other people can’t see gives you great vision.");
            }
            else
            {
                Console.WriteLine("I'm sorry. We could not find a quote for your job.");
            }
        }
        static void Main(string[] args)
        {
            jobtitle("Developer");
            Console.ReadLine();
        }
    }
}
