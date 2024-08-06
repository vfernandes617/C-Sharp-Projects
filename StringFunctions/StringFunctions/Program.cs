using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Valter";
            //string quote = "The Man said, \"Hello\", Valter; \n Hello on s new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Valter";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name IS VALTER");

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
