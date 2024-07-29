using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person 1 
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hourly worked per week:");
            double hoursPerWeek1 = Convert.ToDouble(Console.ReadLine());

            // Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hourly worked per week:");
            double hoursPerWeek2 = Convert.ToDouble(Console.ReadLine());

            //Calculating annual salaries
            double annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            double annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            //Annual salaries
            Console.WriteLine("Annual Salary of Person 1:"+ annualSalary1);
            Console.WriteLine("Annual salary of Person 2:" + annualSalary2);

            //Comparing Salaries
            bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
            Console.WriteLine($"Does Person 1 make more money than Person2?{doesPerson1MakeMore}");
            Console.ReadLine(doesPerson1MakeMore);
        } 
    }
}
