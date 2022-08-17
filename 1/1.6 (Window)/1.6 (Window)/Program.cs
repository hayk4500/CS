using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace _1._6__Window_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Interaction.InputBox("Enter your name", "Lets meet!");
            int year = Convert.ToInt32(Interaction.InputBox("Year of birth", "Lets meet!!!"));

            int age = 2022 - year;

            MessageBox.Show($"Nice meet! Lets see your info:\n Name: {name}\n Age: {age}");
        }
    }
}
