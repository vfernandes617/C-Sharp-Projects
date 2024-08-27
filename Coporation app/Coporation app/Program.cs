using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coporation_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects
            Employee employee1 = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            Employee employee2 = new Employee()
            {
                FirstName = "Another",
                LastName = "Person",
                Id = 1
            };

            // Call the SayName() method
            employee1.SayName();

            // Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = employee1;

            // Call the Quit() method using the IQuittable interface
            quittableEmployee.Quit();

            // Compare two Employee objects using the overloaded "==" operator
            bool areEqual = employee1 == employee2;
            Console.WriteLine($"Are these employees equal? {areEqual}");
            Console.ReadLine();
        }
    }
}