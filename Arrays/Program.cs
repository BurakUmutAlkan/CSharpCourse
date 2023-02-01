using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First Approach

            string[] students = new string[3];

            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            // Second Approach

            string[] studentsTwo = { "Engin", "Derin", "Salih" };

            foreach (string student in studentsTwo)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("******************");

            // Multi-Layered Arrays

            string[,] regions = new string[5, 3]
            {
                { "Istanbul", "Izmit", "Tekirdag" },
                { "Ankara", "Konya", "Kirikkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Trabzon", "Rize", "Samsun" },
                { "Izmir", "Mugla", "Aydin" }
            };

            for(int row = 0; row <= regions.GetUpperBound(0); row++)
            {
                for(int column = 0; column <= regions.GetUpperBound(1); column++)
                {
                    Console.WriteLine(regions[row, column]);
                }

                Console.WriteLine("******************");
            }

            Console.ReadKey();
        }
    }
}
