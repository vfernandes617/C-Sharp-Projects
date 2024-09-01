using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            //create a list of employees
  {
      new Employee { FirstName = "John", LastName = "Dog", Id = 0 },
      new Employee {  FirstName = "Joe", LastName = "Doe", Id = 1},
      new Employee { FirstName = "James", LastName = "Frog", Id = 2 },
      new Employee { FirstName = "Jesse", LastName = "Tech", Id = 3 },
      new Employee { FirstName = "Joe", LastName = "Lopes", Id = 4 },
      new Employee { FirstName = "Theresa", LastName = "Cat", Id = 5 },
      new Employee { FirstName = "Yanet", LastName = "Grill", Id = 6 },
      new Employee { FirstName = "Jessica", LastName = "Lovett", Id = 7 },
      new Employee { FirstName = "Gross", LastName = "Groiss", Id = 8 },
      new Employee { FirstName = "Brittany", LastName = "Soda", Id = 9 },

  };
            //List of employees named Joe
            //List<Employee> joeEmployees = new List<Employee>();

            //foreach (var employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        joeEmployees.Add(employee);

            //    }
            //}


            //// Print the list of Joe employees
            //foreach (Employee joeEmployee in joeEmployees)
            //{
            //    Console.WriteLine($"{joeEmployee.FirstName} {joeEmployee.LastName}");
            //}

            // Lambda expression for Joe
            List<Employee> joeEmployees = employees.Where(x => x.FirstName == "Joe").ToList();

            //Lambda expression for ID
            List<Employee> EmployeeId = employees.Where(y => y.Id > 5).ToList();

        }
    }
}