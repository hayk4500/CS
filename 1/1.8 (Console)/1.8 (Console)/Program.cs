﻿using System;
namespace _1._8__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1 + num2;

            Console.WriteLine($"Additional is: {num3}");
            Console.ReadKey();
        }
    }
}
