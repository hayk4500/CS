using System;

namespace _1._5__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int age = 2022 - year;
            Console.WriteLine($"You {age} years old!");
            Console.ReadKey();
        }
    }
}
