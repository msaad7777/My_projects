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

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 2:");
            Console.WriteLine("-----------");
            Exercise2();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 3:");
            Console.WriteLine("-----------");
            Exercise3();

            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine("EXERCISE 4:");
            Console.WriteLine("-----------");
            Exercise4();

            Console.WriteLine();
            Console.WriteLine("--- DONE!");
            Console.ReadKey();
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
                Console.WriteLine($"{Number,10} {square,8} {cube,8}");

            }
            Console.WriteLine("\n........................");


        }

        static void Exercise2()
        {
            // INPUT
            Console.WriteLine("Intererest Rate increase Account Balance");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|  Year |   Balance   |");
            Console.WriteLine("-----------------------");
            // PROCESSING
            int year = 0;
            double Balance = 2000;


            while (year < 10)
            {
                // OUTPUT

                Balance = Balance + 0.09 * Balance;
                year = year + 1;
                Console.WriteLine($"{year,5} {Balance,13:C}");
            }

            Console.WriteLine("\n........................");
        }

        static void Exercise3()
        {
            // INPUT
            int counter = 1;
            int sum = 0;
            double average = 0;
            int grade;
            int menu = 0;

            // PROCESSING
            do
            {
                Console.Write($"Please enter your grade {counter}: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade > 100)
                {
                    Console.WriteLine("Invalid Selection");
                    break;
                }
                else if (grade < 0)
                {
                    Console.WriteLine("Invalid Selection");
                    break;
                }
                sum += grade;
                counter++;
            } while (grade != 999);

            average = sum / counter;

            if (grade == 999)
            {
                Console.WriteLine("Invalid Selection");
                average = (double)sum / (counter - 1);
                Console.WriteLine($"The Number of grades are {counter}");
                Console.WriteLine($"The sum of grades is {sum}");
                Console.WriteLine($"The average is {average}");
                //Console.ReadKey();
            }







        }

        static void Exercise4()
        {

            int x, y;
            const int Mohammed_saad = -7;


            for (x = 1; x <= 5; x=x+0.5)

            {
                Console.WriteLine("x  2*X^2  -x   -7   y   (x,y)");
                Console.WriteLine("-----------------------------");
                y = 2*x*x-x- Mohammed_saad
                // OUTPUT
                Console.WriteLine($"{x} {2*x^2} {-x} {Mohammed_saad} {y} {x,y}");

            }
            Console.WriteLine("\n........................");



        }
    }