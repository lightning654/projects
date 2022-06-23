using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_grade
{
    class Program
    {
        static void grade(double x)
        {
            if (x < 2)
            {
                Console.WriteLine("A mark of " +x+ " is a grade U. You needed " + (2-x) + " more mark/s for the next grade.");
            }
            else if (x >= 2 && x<4)
            {
                Console.WriteLine("A mark of " + x + " is a grade 1. You needed " + (4 - x) + " more marks  for the next grade.");
            }
            else if (x >= 4 && x<13)
            {
                Console.WriteLine("A mark of " + x + " is a grade 2. You needed " + (13 - x) + " more marks  for the next grade.");
            }
            else if (x >= 13 && x<22)
            {
                Console.WriteLine("A mark of " + x + " is a grade 3. You needed " + (22 - x) + " more marks  for the next grade.");
            }
            else if (x >= 22 && x<31)
            {
                Console.WriteLine("A mark of " + x + " is a grade 4. You needed " + (31 - x) + " more marks  for the next grade.");
            }
            else if (x >= 31 && x<41)
            {
                Console.WriteLine("A mark of " + x + " is a grade 5. You needed " + (41 - x) + " more marks for the next grade.");
            }
            else if (x >= 41 && x<54)
            {
                Console.WriteLine("A mark of " + x + " is a grade 6. You needed " + (54 - x) + " more marks for the next grade.");
            }
            else if (x >= 54 && x<67)
            {
                Console.WriteLine("A mark of " + x + " is a grade 7. You needed " + (67 - x) + " more marks for the next grade.");
            }
            else if (x >= 67 && x<80)
            {
                Console.WriteLine("A mark of " + x + " is a grade 8. You needed " + (80 - x) + " more marks for the next grade.");
            }
            else if (x >= 80)
            {
                Console.WriteLine("A mark of " + x + " is a grade 9.");
            }
        }
        static void Main(string[] args)
        {
            grade(59);
            Console.ReadLine();
        }
    }
}
