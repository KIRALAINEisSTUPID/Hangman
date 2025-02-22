using System;
using lab;
class Program
{
    static void Main(string[] args)
    {
        string hiddenText;
        int hiddentTextCharAmount;
        Console.ForegroundColor = ConsoleColor.Magenta;
        string Hangman = "Hangman";

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"Welcome to ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(Hangman);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Thread.Sleep(2000);
        Console.Clear();
        Console.Write("Enter your text to start:"); hiddenText = Convert.ToString(Console.ReadLine());
        hiddentTextCharAmount = Game.GetLenght(hiddenText);
        Console.Clear();
        Console.WriteLine("Guess Word!");
        for (int i = 0; i < hiddentTextCharAmount; i++)
        {
            Console.Write("_");
        }
        Game.CheckChars(hiddenText);
        


    }
}
