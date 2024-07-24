using System;

namespace Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What course are you on? ");
            string course = Console.ReadLine();

            Console.Write("What page number? ");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp = bool.Parse(Console.ReadLine());

            Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.Write("How many hours did you study today?");
            int studyHours = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("You answered all the questions");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Page Number: {pageNumber}");
            Console.WriteLine($"Needs Help: {needsHelp}");
            Console.WriteLine($"Positive Experiences: {positiveExperiences}");
            Console.WriteLine($"Feed Back: {feedBack}");
            Console.WriteLine($"Study Hours: {studyHours}");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); 
        }
    }
}
