using System;

namespace TranslateToRobberLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Translate text to the Robber Language!");
                Console.Write("Input to translate: ");
                string input = Console.ReadLine();

                string robberLanguage = Translator.RobberLanguage(input);

                Console.WriteLine(robberLanguage);
            }
        }
    }
}
