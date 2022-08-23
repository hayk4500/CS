using System;

namespace _3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int thousands = num / 1000;
            Console.WriteLine(thousands);
            Console.ReadKey();
        }
    }
}
