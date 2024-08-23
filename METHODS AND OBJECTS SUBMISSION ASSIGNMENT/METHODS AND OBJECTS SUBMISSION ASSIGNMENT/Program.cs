using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            person.SayName();
        }
    }
}
