using System;

namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 4 && num < 11)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
