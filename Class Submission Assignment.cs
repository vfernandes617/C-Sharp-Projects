using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class (though it's static, so no need to create an instance)

            // Get user input
            Console.WriteLine("Enter an integer:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call the method that divides by 2
            Divider.DivideByTwo(userInput);

            // Call the overloaded method with a double
            Console.WriteLine("Enter a double:");
            double userDoubleInput = Convert.ToDouble(Console.ReadLine());
            Divider.DivideByTwo(userDoubleInput);

            // Call the method with output parameters
            Divider.DivideByTwoOutput(userInput, out int result);
            Console.WriteLine($"Using output parameter: The result of dividing {userInput} by 2 is: {result}");
        }
    }