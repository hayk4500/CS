﻿using System;

namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 5 == 2 && num % 7 == 1) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Yes"); }
            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("No"); }
            Console.ReadKey();
        }
    }
}
