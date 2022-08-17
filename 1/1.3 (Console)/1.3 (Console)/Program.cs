using System;

namespace _1._3__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Date is: {day}/{month}/{year}");
            Console.ReadKey();
        }
    }
}
