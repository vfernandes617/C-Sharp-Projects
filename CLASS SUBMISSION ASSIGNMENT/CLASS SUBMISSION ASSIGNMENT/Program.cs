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
            VoidINT voidINT = new VoidINT();

            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

          
            voidINT.WrongAnswer(num);

            // Call the method with an output parameter
            int result;
            voidINT.WrongAnswer(num, out result);
            Console.WriteLine("The result is: " + result);

            // Call the overloaded method
            voidINT.DivideByTwoAgain(5.5);
        }
    }
}
