using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annoymous_income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            int hourlyRate1 = GetValidIntegerInput("Hourly Rate?");
            int hours1 = GetValidIntegerInput("Hours worked per week?");
            int salary1 = hourlyRate1 * hours1 * 52;


            Console.WriteLine("Person 2");
            int hourlyRate2 = GetValidIntegerInput("Hourly Rate?");
            int hours2 = GetValidIntegerInput("Hours worked per week?");
            int salary2 = hourlyRate1 * hours1 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);


            //Comparing Salaries
            bool doesPerson1MakeMore = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(doesPerson1MakeMore);
            Console.ReadLine(); }

        static int GetValidIntegerInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                try
                {
                    result = Convert.ToInt32(input);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            return result;
        }
        }
    }

        
    

