using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    abstract class Person
    {
        // Properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Abstract method SayName
        public abstract void SayName();
    }

}