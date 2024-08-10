using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //One-dimensional array of strings
            string[] Fruits = new string[] { "Bannana", "strawberries", "cherries", "pear", "apple", "melon" };

            Console.WriteLine("Enter a fruit name:");
            string userInput = Console.ReadLine();

            // Loop through the array and append user input
            for (int i = 0; i < Fruits.Length; i++)
            {
                Fruits[i] += " " + userInput;
            }

            Console.WriteLine("\nYour smoothy mix is");
            foreach (string text in Fruits)
            {
                Console.WriteLine(text);
            }

            Console.ReadLine();
        }
    }
}
