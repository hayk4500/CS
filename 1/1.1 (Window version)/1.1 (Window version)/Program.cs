using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _1._1__Window_version_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Interaction.InputBox("Enter your name: ", "Hi!");
            string surename = Interaction.InputBox("Enter your surename: ", "Hi!");
            MessageBox.Show($"Hello! {name} {surename}");
        }
    }
}
