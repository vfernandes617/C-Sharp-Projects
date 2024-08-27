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
        // Overload the "==" operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if either object is null
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return ReferenceEquals(emp1, emp2);
            }

            // Compare by Id
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator 
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals() to ensure consistency with the overloaded operators
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
            {
                return false;
            }

            Employee other = (Employee)obj;
            return this.Id == other.Id;
        }
    }
}
