using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace lab
{
    class Game
    {
         public static int GetLenght(string arg)
         {
            int linesAmount = arg.Length;
            return linesAmount;
        
         }

        public static void CheckChars(string hiddenWord)
        {
            char[] wordArray = hiddenWord.ToCharArray(); 
            char keys = Console.ReadKey().KeyChar;
            int index = hiddenWord.IndexOf(keys);

            while (true)
            {
                if(index != -1)
                {
                    wordArray[index] = keys;
                    Console.WriteLine(wordArray);
                }



                }
            }
        }
}
