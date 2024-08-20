using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number to perform math operations on
            Console.WriteLine("Enter a number to perform math operations on:");
            string userInput = Console.ReadLine();

            // Attempt to parse the user input to an integer
            if (int.TryParse(userInput, out int number))
            {
                // Create an instance of MathOperations class
                Class1 mathOps = new Class1();

                int result1 = mathOps.AddTen(number);
                Console.WriteLine($"The result of adding 10 to {number} is: {result1}");

                int result2 = mathOps.SubtractTen(number);
                Console.WriteLine($"The result of Subtracting {number} by 10 is: {result2}");

                int result3 = mathOps.DivideTen(number);
                Console.WriteLine($"The result of Dividing {number} by 10: {result3}");
            }
            else
            {
                
                Console.WriteLine("Invalid input. Please enter a valid integer.");

            }
            Console.ReadLine();
        }
    }
}
