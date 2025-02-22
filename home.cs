using System;
using lab;
class Program
{
    static void Main(string[] args)
    {
        string hiddenText;
        Console.ForegroundColor = ConsoleColor.Magenta;
        string Hangman = "Hangman";

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Welcome to ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(Hangman);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Thread.Sleep(2000);
        Console.Clear();
        Console.Write("Enter your text to start:");hiddenText = Convert.ToString(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("");
        


    }
}
