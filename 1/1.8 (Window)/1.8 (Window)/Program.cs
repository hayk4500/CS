using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _1._8__Window_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Interaction.InputBox("Enter the first number", "AddCalc"));
            int num2 = Convert.ToInt32(Interaction.InputBox("Enter the second number", "AddCalc"));
            int num3 = num1 + num2;
            MessageBox.Show($"Additional is: {num3}", "Result Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
