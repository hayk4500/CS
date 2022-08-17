using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _1._3__Window_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Interaction.InputBox("Enter day", "Date constructor"));
            int month = Convert.ToInt32(Interaction.InputBox("Enter month", "Date constructor"));
            int year = Convert.ToInt32(Interaction.InputBox("Enter year", "Date constructor"));

            MessageBox.Show($"Your entered date: {day}/{month}/{year}");
        }
    }
}
