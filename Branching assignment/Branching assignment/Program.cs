using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_assignment
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What is your favorite number?");
            int favnum = Convert.ToInt32(Console.ReadLine());

            string result = favnum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number";

            Console.WriteLine(result);
            Console.ReadLine();
        }
        //{
        //    int roomTemperature = 70;
        //    Console.WriteLine("Hi, what is your name?");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Hi, " + ", what is the temperature where you are?");
        //    int currentTemperature = Convert.ToInt32(Console.ReadLine());

        //    if (currentTemperature == roomTemperature)
        //    {
        //        Console.WriteLine("It is exactly room tempurature.");
        //    }
        //    else if (currentTemperature > roomTemperature)
        //    {
        //        Console.WriteLine("It is warmer than room temperature");
        //    }
        //     else if (roomTemperature > currentTemperature) 
        //    {
        //        Console.WriteLine(" It is colder than room temperature.");
        //     }
        //    else
        //    {
        //        Console.WriteLine("oook  ..... something went wrong");
        //    }
        //    Console.ReadLine();

             
                    //int currentTemperature = 90;
                    //int roomTemperature = 70;

                    //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp";

                    //Console.WriteLine(comparisonResult);
                    //Console.ReadLine();
                    //if (currentTemperature == roomTemperature)
                    //{
                    //    Console.WriteLine("It is exactly room temperature.");
                    //}
                    //else if (currentTemperature>roomTemperature)
                    //{
                    //    Console.WriteLine("It is warmer than room temperature.");
                    //}
                    //else if (roomTemperature > currentTemperature)
                    //{
                    //    Console.WriteLine("Room temperature is warmer that current temperature");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("It is not exaclty room temperature.");
                    //}
                    //Console.ReadLine();
                }
            }


