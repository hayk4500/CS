using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace _1._9__Window_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Interaction.InputBox("Enter number:", "Opa!"));
            MessageBox.Show($"Numbers is: {num - 1} {num} {num + 1}");
        }
    }
}
