using System;
using System.Threading;

namespace lab
{
    class Game
    {
        //---------------MAIN--------------------------
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to the game, please choose one option:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Russian");

            char keys = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (keys)
            {
                case '1':
                    Console.WriteLine("You selected English.");
                    EngMainMenu();
                    break;
                case '2':
                    Console.WriteLine("Вы выбрали русский.");
                    RusMainMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    MainMenu();
                    break;
            }
        }
        //-------------------Game in Eng lang------------- 
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


        //-----------------Game in RUS-------------------


        public static void RusMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string Hangman = "Виселицу";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Добро пожаловать в   ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Hangman);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("чтоб начинать игру нужен ввести слово: ");
            string hiddenText = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("найди слово:");
            for (int i = 0; i < hiddenText.Length; i++)
            {
                Console.Write("_ ");
            }
            Console.WriteLine();
            Game.RusCheckChars(hiddenText);
        }
        public static int RusGetLength(string arg)
        {
            return arg.Length;
        }

        public static void RusCheckChars(string hiddenWord)
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
                Console.Write("Ввести букву: ");
                char guess;
                try
                {
                    guess = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("что-то пошло не так...");
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
                    Console.WriteLine($"Неправильно! Осталось: {maxAttempts - attempts} шансов");
                }
                else
                {
                    Console.WriteLine("Верно ...");
                }

                Console.Write("Слово: ");
                foreach (char c in wordArray)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();

                if (new string(wordArray).Equals(hiddenWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Ты победила/a...Поздравляю");
                    return;
                }
            }
            Console.WriteLine($"\n АХАХА ты проиграл/a слово было: {hiddenWord}");

        }
    }
}