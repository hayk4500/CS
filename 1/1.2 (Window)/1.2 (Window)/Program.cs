using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _1._2__Window_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Interaction.InputBox("Enter name: ", "Hi!");
            string age = Interaction.InputBox("How old are you?", "Kek");
            MessageBox.Show($"Good! You are {name} with {age} years!", "Lol");
        }
    }
}
