using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETERS_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate the employee object with string as its generic parameter 
            Employee<string> employee = new Employee<string>();
            employee.Things.Add("Books");
            employee.Things.Add("Pens");

            //Instantiates Employee as an int type
            Employee<int> intEmployee = new Employee<int>();
            intEmployee.Things.Add(10);
            intEmployee.Things.Add(20);
            intEmployee.Things.Add(30);

            // Print the "Things" of both employees
            Console.WriteLine("String Employee Things:");
            Console.ReadLine();
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nInt Employee Things:");
            foreach (int thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}