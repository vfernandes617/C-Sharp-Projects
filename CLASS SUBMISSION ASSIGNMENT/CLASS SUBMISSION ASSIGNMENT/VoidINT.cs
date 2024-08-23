using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    internal class VoidINT
    {
        // Method without output parameter
        public void WrongAnswer(int number)
        {
            Console.WriteLine("Processing number without output parameter: " + number);
        }

        // Method with output parameter
        public void WrongAnswer(int number, out int result)
        {
            result = number * 2; // Example logic for the method
        }

        // Overloaded method that accepts a double
        public void DivideByTwoAgain(double number)
        {
            Console.WriteLine("Divide by two: " + (number / 2));
        }
    }
}