using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace _1._7__Window_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Interaction.InputBox("Enter ages: ", "Hi!"));

            int year = 2022 - age;

            MessageBox.Show($"Year of birth: {year}");
        }
    }
}
