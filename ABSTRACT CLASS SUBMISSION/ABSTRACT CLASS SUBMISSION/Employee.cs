using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    class Employee : Person, IQuittable
    {
        // Implementing the SayName method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit(Person person)
        {
            throw new NotImplementedException();
        }

        public static
    }
}