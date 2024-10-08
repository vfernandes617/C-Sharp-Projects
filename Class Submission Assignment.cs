﻿using System;
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
            // Ask user to input a number
            Console.WriteLine("Enter a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Using the overloaded method (without output parameter)
            VoidINT.DivideByTwo(userNumber);

            // Using the overloaded method (with output parameter)
            string outputMessage;
            VoidINT.DivideByTwo(userNumber, out outputMessage);
            Console.WriteLine(outputMessage);

            
        }
    }
}