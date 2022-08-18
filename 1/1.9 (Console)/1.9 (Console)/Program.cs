using System;


namespace _1._9__Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result is: {num - 1} {num} {num + 1}");
            Console.ReadKey();
        }
    }
}
