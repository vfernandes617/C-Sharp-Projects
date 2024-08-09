using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //One-dimensional Array of strings
            string[] stringArray = { "Mario", "Donkey-Kong", "Zelda", "Star Fox", "Metriod" };
            Console.WriteLine("Select a game from 0-4");

            int stringIndex;
            if (int.TryParse(Console.ReadLine(), out stringIndex) && stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine($"Game selected {stringIndex}: {stringArray[stringIndex]}");
            }
            else
            {
                Console.WriteLine("Index out of bonds.");
            }

            // One dimensional array of integers
            int[] intArray = { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine("Select an index (0 to 4) to display the corresponding integer:");

            int intIndex;
            if (int.TryParse(Console.ReadLine(), out intIndex) && intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine($"Integer at index {intIndex}: {intIndex}: {intArray[intIndex]}");
            }
            else
            {
                Console.WriteLine("Index out of bounds.");
            }

            //List of strings
            List<string> stringList = new List<string> { "Basketball", "Baseball", "Football", "Soccer", "Hockey" };

            Console.WriteLine("Select a great sport from 0-4");

            int listIndex;
            if (int.TryParse(Console.ReadLine(), out listIndex) && listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine($"the Sport selected is {listIndex}: {stringList[listIndex]}");
            }
            else
            {
                Console.WriteLine("Index out of bounds");
            }
            //user input
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}

