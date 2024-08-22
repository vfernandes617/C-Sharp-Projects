using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_CLASS
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Voidmethod voidmethod = new Voidmethod();

            //Calling method in class passing two numbers

            Console.WriteLine("Enter in a number");

            Voidmethod.Display(3, 10);

            //Calling Method
            Console.WriteLine("\nCalling the method:");
                Voidmethod.Display(num1:20, num2:20);
        }
 
    }
    
}
