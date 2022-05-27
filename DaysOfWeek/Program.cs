using System;

namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program print the days of week to the Console");
            Console.WriteLine("Please choose a number:");
            Console.WriteLine("1: Monday");
            Console.WriteLine("2: Tuesday");
            Console.WriteLine("3: Wednesday");
            Console.WriteLine("4: Thursday");
            Console.WriteLine("5: Friday");
            Console.WriteLine("6: Saturday");
            Console.WriteLine("7: Sunday");

            var number = 0;

            var isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber)
            {
                PrintDay(number);
            }
            else
            {
                Console.WriteLine("You can enter numbers 1-7");
            }
        }
        static void PrintDay(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("It is Monday");
                    break;
                case 2:
                    Console.WriteLine("It is Thursday");
                    break;
                case 3:
                    Console.WriteLine("It is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It is Tuesday");
                    break;
                case 5:
                    Console.WriteLine("It is Friday");
                    break;
                case 6:
                    Console.WriteLine("It is Saturday");
                    break;
                case 7:
                    Console.WriteLine("It is Sunday");
                    break;

                default:
                    Console.WriteLine("I don't know what you do.");
                    break;
            }
        }
    }
}