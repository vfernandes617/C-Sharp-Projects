using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Branching_submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Print the welcome message
                Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

                // Prompt for the package weight
                Console.Write("Please enter the package weight: ");
                double weight = Convert.ToDouble(Console.ReadLine());

                // Check if the package is too heavy
                if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    return;
                }

                // Prompt for the package width
                Console.Write("Please enter the package width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                // Prompt for the package height
                Console.Write("Please enter the package height: ");
                double height = Convert.ToDouble(Console.ReadLine());

                // Prompt for the package length
                Console.Write("Please enter the package length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                // Check if the package is too big
                double dimensionTotal = width + height + length;
                if (dimensionTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                    return;
                }

                // Calculate the quote
                double quote = (width * height * length * weight) / 100.0;

                // Display the quote
                Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
                Console.ReadLine();
            }
        }
    }
    }


