using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace _1._4__Window_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Interaction.InputBox("Enter month name", "Kek");
            int days = Convert.ToInt32(Interaction.InputBox("Enter days", "Lol"));

            MessageBox.Show($"Your entered month {month} has {days} days");
        }
    }
}
