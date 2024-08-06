 using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
            do
            {



                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again ");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine(" you guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine(" You guessed the number 12. That is correct");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (isGuessed == false);
                    Console.ReadLine();

            //a while statment example
            int targetNumber = 8;
            bool guessedCorrectly = false;

            Console.WriteLine("This is a numbered guessing game!");
            Console.WriteLine("Guess the number between 1 and 10.");

            while (!guessedCorrectly)
            {  Console.WriteLine("Enter your guess:")
                    string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    if guess == targetNumer)
                    {
                        guessedCorrectly = true;
                        Console.WriteLine("Check that out you guess correctly");
                    }
                    else
                    {
                        Console.WriteLine("You guessed wrong");
                    }
                }
                else
                {
                    Console.WriteLine(" That entry does not work . put in a number");
                }

            }
        }
    }

