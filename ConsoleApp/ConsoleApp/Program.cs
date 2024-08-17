using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // One-dimensional array of fruits
            string[] originalFruits = new string[] { "Banana", "Strawberry", "Cherry", "Pear", "Apple", "Melon" };

            // Infinite loopwhile (true)
            {
                Console.WriteLine("Type in a fruit for your smoothie (e.g., Banana, Strawberry, Cherry, Pear, Apple, Melon):");
                string userInput = Console.ReadLine()?.ToLower();

                // Normalize the fruit names in the array for comparison
                string[] normalizedFruits = originalFruits.Select(fruit => fruit.ToLower()).ToArray();

                if (userInput == null || !normalizedFruits.Contains(userInput))
                {
                    Console.WriteLine("Invalid fruit. Please try again.");
                    // Skip the rest of the loop

                }

                // Create a new array to hold the smoothie mix
                string[] smoothieMix = new string[originalFruits.Length];

                for (int i = 0; i < originalFruits.Length; i++)
                {
                    smoothieMix[i] = originalFruits[i] + " " + userInput;
                }

                Console.WriteLine("\nYour smoothie mix is:");
                foreach (string text in smoothieMix)
                {
                    Console.WriteLine(text);
                }

                    int[] orders = { 1, 2, 3, 4, 5, 6, };
                    int v = 0;

                    //Loop using "<=" operator
                    while (v < orders.Length - 1)
                    {
                        Console.WriteLine("Orders:" + orders[v]);
                        v++;
                    }
                    Console.WriteLine("\nloop finished using '<=' operator.");
                }
                {
                    // A list of unique strings
                    List<string> uniqueFruits = new List<string> { "Banana", "Strawberry", "Cherry", "Pear", "Apple", "Melon" };

                    // Ask the user to input text to search for in the list
                    Console.WriteLine("Please enter a fruit name to search in the list:");
                    string userInput2 = Console.ReadLine();

                    // Variable to track if a match was found
                     bool matchFound = false;

                    // Loop through the list to search for the input
                     for (int i = 0; i < uniqueFruits.Count; i++)
                    {
                        if (uniqueFruits[i].Equals(userInput2, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Match found at index: {i}");
                            matchFound = true;
                            break; // Stop the loop once a match is found
                    }
                }

                // If no match was found, inform the user
                if (!matchFound)
                {
                    Console.WriteLine("No match found in the list.");

                    // string list that has two identical strings
                    List<string> list = new List<string> {"Artichoke","Broccolini","Carrots","Kale","Kale","Mushrooms","Carrots" };
                    
                    //Foreach loop to evaluate eat item in the list
                    foreach (string s in list) { Console.WriteLine(s); }

                }
                Console.WriteLine("\nDo you want to continue? (yes/no):");
                string continueInput = Console.ReadLine()?.ToLower();
                if (continueInput != "yes")
                {
                    // Exit the loop
                }
            }
        }
    }
}

