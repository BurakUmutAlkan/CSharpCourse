using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();

            var result = Add2(20, 30);
            Console.WriteLine(result);

            result = Add3(20);
            Console.WriteLine(result);

            int numberOne = 20;
            int numberTwo = 100;
            result = Add4(numberOne, numberTwo);
            Console.WriteLine(numberOne);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int Add3(int numberOne, int numberTwo = 30)
        {
            return numberOne + numberTwo;
        }

        static int Add4(int numberOne, int numberTwo)
        {
            numberOne = 30;
            return numberOne + numberTwo;
        }
    }
}
