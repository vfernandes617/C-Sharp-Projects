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
            // Instantiate and initialize an Employee object
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the overridden SayName() method
            employee.SayName();

            // Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit() method using the IQuittable interface
            quittableEmployee.Quit();
        }
    }
}