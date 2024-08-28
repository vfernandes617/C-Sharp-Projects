using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETERS_SUBMISSION_ASSIGNMENT
{//class with gerneric parameter type
    public class Employee<T>
    {
        //adding a property to the employee type called things and having it data type be a generic list
        public List<T> Things { get; set; } = new List<T>();
    }
}
