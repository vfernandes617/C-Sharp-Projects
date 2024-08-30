using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT2
{
    internal static class MathOPS
    {
        // Void method to divide a number by 2
        public static void DivideByTwo(int number, out int result)
        {
            result = number / 2;
        }

        // Overloaded method - version 1 (no output parameter)
        public static void DivideByTwo(int number)
        {
            int result;
            DivideByTwo(number, out result);
            Console.WriteLine($"Result without output parameter: {result}");
        }

        // Overloaded method - version 2 (with output parameter)
        public static void DivideByTwo(int number, out string message)
        {
            int result;
            DivideByTwo(number, out result);
            message = $"Result with output parameter: {result}";
        }
    }
}