using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATETIME_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Current time and date is:  " + dateTime);

            Console.WriteLine("Enter how many hours you would like to work: ");
            string userInput = Console.ReadLine();
            int hours;
            if (int.TryParse(userInput, out hours))
            {
                DateTime workedTime = dateTime.AddHours(hours);
                Console.WriteLine("In " + hours + " you would have worked this much: " + workedTime);
               
            }
           
            else
            {
                Console.WriteLine("invalid input. Please try a number.");
            }
            Console.ReadLine();
        }
    }
}
