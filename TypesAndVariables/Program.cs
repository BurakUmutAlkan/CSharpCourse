using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types

            // Integer (between -2.147.483.648 and 2.147.483.647)

            int numberOne = 2147483647;

            // Long (between -9.223.372.036.854.775.808 and 9.223.372.036.854.775.807)

            long numberTwo = 9223372036854775807;

            // Short (between -32.768 and 32.767)

            short numberThree = 32767;

            // Byte (between 0 and 255)

            byte numberFour = 255;

            // Bool (True or False)

            bool condition = false;

            // Char (contains only one character)

            char character = 'A';

            // Double

            double numberFive = 3.14d;

            Console.WriteLine("Number One: {0}", numberOne);
            Console.WriteLine("Number Two: {0}", numberTwo);
            Console.WriteLine("Number Three: {0}", numberThree);
            Console.WriteLine("Number Four: {0}", numberFour);
            Console.WriteLine("Condition: {0}", condition);
            Console.WriteLine("Character: {0}", character);
            Console.WriteLine("Number Five: {0}", numberFive);


            Console.ReadKey();
        }
    }
}
