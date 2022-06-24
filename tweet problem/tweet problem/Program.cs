using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tweet_problem
{
    class Program
    {
        // Function to return if post is less than or equal to 20 characters

        static bool GoodPost(string Tweet)
        {
            if (Tweet.Length <= 20)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine(GoodPost("social networking"));
            Console.ReadLine();
        }
    }
}
