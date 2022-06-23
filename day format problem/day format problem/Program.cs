using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_format_problem
{
    class Program
    {
        //function to return the format of a day
        static string DayFormat(int Day, string DayFormat)
        {
            
            if (Day == 1)
            {
                if (DayFormat == "day")
                {
                    return "Monday";
                }
                else if (DayFormat == "shortday")
                {
                    return "Mon";
                }
                else if (DayFormat == "char")
                {
                    return "M";
                }
            
            }
            if (Day == 2)
            {
                if (DayFormat == "day")
                {
                    return "Tuesday";
                }
                else if (DayFormat == "shortday")
                {
                    return "Tue";
                }
                else if (DayFormat == "char")
                {
                    return "Tu";
                }
          
            }
            if (Day == 3)
            {
                if (DayFormat == "day")
                {
                    return "Wednesday";
                }
                else if (DayFormat == "shortday")
                {
                    return "Wed";
                }
                else if (DayFormat == "char")
                {
                    return "W";
                }
           
            }
            if (Day == 4)
            {
                if (DayFormat == "day")
                {
                    return "Thursday";
                }
                else if (DayFormat == "shortday")
                {
                    return "Thu";
                }
                else if (DayFormat == "char")
                {
                    return "Th";
                }
            
            }
            if (Day == 5)
            {
                if (DayFormat == "day")
                {
                    return "Friday";
                }
                else if (DayFormat == "shortday")
                {
                    return "Fri";
                }
                else if (DayFormat == "char")
                {
                    return "F";
                }
                
            }
            if (Day == 6)
            {
                if (DayFormat == "day")
                {
                    return "Saturday";
                }
                else if (DayFormat == "shortday")
                {
                    return "Sat";
                }
                else if (DayFormat == "char")
                {
                    return "Sa";
                }
                
            }
            if (Day == 7)
            {
                if (DayFormat == "day")
                {
                    return "Sunday";
                }
                else if (DayFormat == "shortday")
                {
                    return "Sun";
                }
                else if (DayFormat == "char")
                {
                    return "Su";
                }
               
            }
            return "false";

        }
        static void Main(string[] args)
        {


            Console.WriteLine(DayFormat(3, "shortday"));
            Console.ReadLine();
        }
    }
}
