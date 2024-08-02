using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for the user's age
            Console.WriteLine("What is your age?");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age) || age < 15)
            {
                Console.WriteLine("Please enter a valid age.");
            }

            // Asking if the user has ever had a DUI
            Console.WriteLine("Have you ever had a DUI? (yes/no)");
            string duiInput;
            bool validDuiInput = false;
            bool hasDui = false;
            while (!validDuiInput)
            {
                duiInput = Console.ReadLine().ToLower();
                if (duiInput == "yes")
                {
                    hasDui = true;
                    validDuiInput = true;
                }
                else if (duiInput == "no")
                {
                    hasDui = false;
                    validDuiInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter 'True' or 'False'.");
                }
            }

            // Determining if the applicant qualifies for car insurance
            bool isQualified = (age >= 15) && !hasDui;

            //Asking about speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            int speedTicket;
            while (!int.TryParse(Console.ReadLine(), out speedTicket) || speedTicket < 3)
            {
                Console.WriteLine("Please enter a valid age.");
            }

            // Displaying the result
            Console.WriteLine($"Congrats you are qualified for Insurance!: {isQualified}");

            // Keeping the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
