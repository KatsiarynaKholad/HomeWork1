using System;

namespace MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program print the multiplication table to the Console");
            Console.WriteLine("Please enter a number:");

            var number = 0;
            var isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber)
            {
                PrintMultiplicationTable(number);
            }
            else
            {
                Console.WriteLine("it isn't a number");
            }
        }
        static void PrintMultiplicationTable(int a)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }
    }
}