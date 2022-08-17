using System;

namespace _1._4__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month name: ");
            string month = Console.ReadLine();
            Console.Write("How much days in this month?: ");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Good! {month} has {days} days!");
            Console.ReadKey();
        }
    }
}
