using System;
namespace _4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int bin = (num >> 2) % 2;
            Console.WriteLine(bin); Console.ReadKey();
        }
    }
}
