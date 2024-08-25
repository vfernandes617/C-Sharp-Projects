using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with firstName "Sample" and lastName "Student"
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call the SayName method
            employee.SayName();

          
            Console.ReadLine();
        }
    }
}