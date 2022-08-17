using System;

namespace _1._6__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int age = 2022 - year;

            Console.WriteLine($"Info about you: \n Name: {name}\n Age: {age}");
            Console.ReadKey();
        }
    }
}
