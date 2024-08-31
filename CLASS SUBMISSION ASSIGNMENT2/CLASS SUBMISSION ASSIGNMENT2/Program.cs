using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input a number
            Console.WriteLine("Enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            MathOPS mathOPS = new MathOPS();

            // Using the overloaded method (without output parameter)
            MathOPS.DivideByTwo(userNumber);

            // Using the overloaded method (with output parameter)
            string outputMessage;
            MathOPS.DivideByTwo(userNumber, out outputMessage);
            Console.WriteLine(outputMessage);
            Console.ReadLine();
        }
    }
}