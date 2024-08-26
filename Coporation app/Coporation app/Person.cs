using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coporation_app
{
    // Abstract class: Person
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method for SayName
        public abstract void SayName();
    }
}