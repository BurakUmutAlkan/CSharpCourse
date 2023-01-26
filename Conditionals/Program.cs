using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;

            // If - Else Block

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }

            // Single Line If

            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            // Else If

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else
            {
                if (number == 11)
                {
                    Console.WriteLine("Number is 11");
                }
            }

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 11)
            {
                Console.WriteLine("Number is 11");
            }

            // Switch

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 11:
                    Console.WriteLine("Number is 11");
                    break;
            }

            Console.ReadKey();
            Console.Clear();

            // Practice Application

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is in range of 0 and 100.");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is in range of 101 and 200.");
            }
            else if (number < 0 && number > 200)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            Console.ReadKey();
        }
    }
}
