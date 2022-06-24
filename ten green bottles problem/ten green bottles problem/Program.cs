using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_green_bottles_problem
{
	internal class Program
	{
		public static void Main()
		{
			int x = 10;
			while (x > 2)
			{
				Console.WriteLine(x + " green bottles hanging on the wall,");
				Console.WriteLine(x + " green bottles hanging on the wall,");
				Console.WriteLine(" and if one green bottle should accidentally fall,");
				x = x - 1;
				Console.WriteLine("there will be " + x + " green bottles hanging on the wall.");

			}
			while (x >= 2)
			{
				Console.WriteLine(x + " green bottles hanging on the wall,");
				Console.WriteLine(x + " green bottles hanging on the wall,");
				Console.WriteLine(" and if one green bottle should accidentally fall,");
				x = x - 1;
				Console.WriteLine(" there will be " + x + " green bottle hanging on the wall.");
			}
			while (x == 1)
			{
				Console.WriteLine(x + " green bottle hanging on the wall,");
				Console.WriteLine(x + " green bottle hanging on the wall,");
				Console.WriteLine(" and if one green bottle should accidentally fall,");
				x = x - 1;
				Console.WriteLine(" there will be " + x + " green bottles hanging on the wall.");

			}
			Console.ReadLine();
				
		}
	}
}
