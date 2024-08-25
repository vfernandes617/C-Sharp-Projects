using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    public static class Divider
    {
        // Void method that divides an integer by 2
        public static void DivideByTwo(int input)
        {
            int result = input / 2;
            Console.WriteLine($"The result of dividing {input} by 2 is: {result}");
        }

        // Method with output parameters
        public static void DivideByTwoOutput(int input, out int result)
        {
            result = input / 2;
        }

        // Overloaded method (same name, different parameter type)
        public static void DivideByTwo(double input)
        {
            double result = input / 2.0;
            Console.WriteLine($"The result of dividing {input} by 2 is: {result}");
        }
    }
}