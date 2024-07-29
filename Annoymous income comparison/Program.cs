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

            // Person 1 
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hourly worked per week:");
            decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

            // Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hourly worked per week:");
            decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine());

            //Calculating annual salaries
            decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            //Comparing Salaries
            bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
            Console.WriteLine($"Does Person 1 make more money than Person 2?");
            Console.WriteLine(doesPerson1MakeMore);
        }
    }
}

        
    

