using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_SUBMISSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class 'MathOps'
            MathOps mathOps = new MathOps();

            //Ask user to input two numbers one at a time
            Console.WriteLine("Enter in a number");
            int UserInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter in a second number if you like press enter to skip.");
            string secondNumber = Console.ReadLine();

            int result;

            //calling the method in the class 
            if (string.IsNullOrEmpty(secondNumber))
            {
                result = mathOps.test(UserInput);

            }
            else
            {
                int secondNumberByUser = int.Parse(secondNumber);
                result = mathOps.test(UserInput, secondNumberByUser);

            }
            Console.WriteLine("The results is:" + result);
            Console.ReadLine();
        }
    }
}
