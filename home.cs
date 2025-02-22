using lab;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        string Hangman = "Hangman";

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Welcome to  ");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(Hangman);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Thread.Sleep(2000);
        Console.Clear();
        Console.Write("To start game you need enter word: ");
        string hiddenText = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Guess word:");
        for (int i = 0; i < hiddenText.Length; i++)
        {
            Console.Write("_ ");
        }
        Console.WriteLine();
        Game.CheckChars(hiddenText);
    }
}
