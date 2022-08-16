using System;

namespace _1._2__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("How old are you?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hi! Your name is {name}, you are {age} years old. Thanks for information!");
            Console.ReadKey();
        }
    }
}
