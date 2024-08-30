using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PARSING_ENUMS_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in the current day of the week(0 gives you Monday and 7 gives you Sunday):");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            DayOfWeek day1 = DayOfWeek.Monday;
            DayOfWeek day2 = DayOfWeek.Tuesday;
            DayOfWeek day3 = DayOfWeek.Wednesday;
            DayOfWeek day4 = DayOfWeek.Thursday;
            DayOfWeek day5 = DayOfWeek.Friday;
            DayOfWeek day6 = DayOfWeek.Saturday;
            DayOfWeek day7 = DayOfWeek.Sunday;
            dayNumber = Convert.ToInt32(Console.ReadLine());

            if (dayNumber >= 0 && dayNumber <= 6)
            {
                DayOfWeek selectedDay = (DayOfWeek)dayNumber;
                Console.WriteLine($"You selected: {selectedDay}");
            }
            else
            {
                Console.WriteLine("Invalid day number! Please enter a value between 0 and 6.");
            }
            

        }
    }
}
