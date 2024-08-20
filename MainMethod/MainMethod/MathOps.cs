using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class MathOps
    {
       
        public int PerformOperation(int number)
        {
            return number + 10;
        }

        public int PerformOperation(decimal number)
        {
            return (int)(number * 2);
        }

       
        public int PerformOperation(string number)
        {
             
            if (int.TryParse(number, out int parsedNumber))
            {
                return parsedNumber - 5;
            }
            else
            {
                throw new ArgumentException("The input string could not be converted to an integer.");
            }
        }
    }
}
