using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Calculator
    {
        //Calculation Methods

        public static decimal Addition(decimal x, decimal y)
        {
           return (x + y);
        }

        public  static decimal Subtraction(decimal x, decimal y)
        {
           return x - y;
        }

        public static decimal Multiplication(decimal x, decimal y)
        {
            return x * y;
        }

        public static decimal Division(decimal x, decimal y)
        {
            return (x / y);
        }

    }
}
