using System;

namespace comp100_test02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 1:");
            Console.WriteLine("-----------");
            Exercise1();
        }

        static void Exercise1()
        {
            // INPUT
            Console.WriteLine("Squares and Cubes of a Number");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|  Number | Square |  Cube  |");
            // PROCESSING

            int Number;
            for (Number = 1; Number <= 10; Number++)

            {
                double square;
                double cube;
                square = Number * Number;
                cube = Number * Number * Number;
                // OUTPUT
                Console.WriteLine($"{Number} {square} {cube}");
                Console.WriteLine("\n........................");
            }
            
        }

    }
}