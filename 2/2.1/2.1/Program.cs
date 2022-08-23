using System;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Yes"); }
            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("No"); }
            Console.ReadKey();
        }
    }
}
