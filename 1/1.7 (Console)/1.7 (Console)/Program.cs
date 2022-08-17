using System;

namespace _1._7__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int year = 2022 - age;

            Console.WriteLine($"Birth year is: {year}");
            Console.ReadKey();
        }
    }
}
