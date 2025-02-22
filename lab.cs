using System;
using System.Threading;

namespace lab
{
    class Game
    {
        public static void MainMenu()
        {

        }
        public static void EngMainMenu()
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
        public static int GetLength(string arg)
        {
            return arg.Length;
        }

        public static void CheckChars(string hiddenWord)
        {
            char[] wordArray = new char[hiddenWord.Length];
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                wordArray[i] = '_';
            }

            int maxAttempts = hiddenWord.Length + 3; 
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.WriteLine();
                Console.Write("Enter letter: ");
                char guess;
                try
                {
                    guess = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Expection occured...");
                    continue;
                }

                bool correctGuess = false;
                for (int i = 0; i < hiddenWord.Length; i++)
                {
                    if (char.ToLower(hiddenWord[i]) == char.ToLower(guess))
                    {
                        if (wordArray[i] != hiddenWord[i])
                        {
                            wordArray[i] = hiddenWord[i];
                            correctGuess = true;
                        }
                    }
                }

                if (!correctGuess)
                {
                    attempts++;
                    Console.WriteLine($"Wront... Attempts left: {maxAttempts - attempts}");
                }
                else
                {
                    Console.WriteLine("A little bit of the right one...");
                }

                Console.Write("Word: ");
                foreach (char c in wordArray)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();

                if (new string(wordArray).Equals(hiddenWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You won...Congrulations");
                    return;
                }
            }
            Console.WriteLine($"\n You lose Hidden word was: {hiddenWord}");
        }
    }
}