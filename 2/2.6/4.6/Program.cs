using System;

namespace _4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int oct = (num & 56) >> 3;
            Console.WriteLine(oct); Console.ReadKey();
        }
    }
}
