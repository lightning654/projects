using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_problem
{
	internal class Program
	{
		static void Main()
		{
			
			for (int i = 1; i <= 50; i++)
			{
				if (i % 3 == 0)
				{
					if (i % 5 == 0)
					{
						Console.WriteLine("fizzbuzz");
						continue;
					}
					Console.WriteLine("fizz");
				}
				else if (i % 5 == 0)
					Console.WriteLine("buzz");
				else
					Console.WriteLine(i);
			}
			Console.ReadLine();


		}
	}
}
