using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coporation_app
{
    // Derived class: Employee (inherits from Person and implements IQuittable)
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // Override the SayName() method in the Employee class
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        // Implement the Quit() method from IQuittable
        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");
        }

    }
}