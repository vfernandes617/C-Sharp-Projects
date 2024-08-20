using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
            {
             
                MathOps mathOps = new MathOps();

              
                Console.WriteLine("Type in an integer");
                string intInput = Console.ReadLine();
                if (int.TryParse(intInput, out int intNumber))
                {
                    // Call the integer method
                    int result1 = mathOps.PerformOperation(intNumber);
                    Console.WriteLine($"Result of adding 10 to the integer {intNumber}: {result1}");
                }
                else
                {
                    Console.WriteLine("Invalid integer input.");
                }

                // Prompt the user for a decimal
                Console.WriteLine("Enter a decimal:");
                string decimalInput = Console.ReadLine();
                if (decimal.TryParse(decimalInput, out decimal decimalNumber))
                {
                    // Call the decimal method
                    int result2 = mathOps.PerformOperation(decimalNumber);
                    Console.WriteLine($"Result of multiplying the decimal {decimalNumber} by 2: {result2}");
                }
                else
                {
                    Console.WriteLine("Invalid decimal input.");
                }

                // Prompt the user for a string that represents an integer
                Console.WriteLine("Enter a string that represents an integer:");
                string stringInput = Console.ReadLine();
                try
                {
                    // Call the string method
                    int result3 = mathOps.PerformOperation(stringInput);
                    Console.WriteLine($"Result of subtracting 5 from the integer represented by the string {stringInput}: {result3}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
