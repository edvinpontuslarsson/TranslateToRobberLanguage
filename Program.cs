using System;

namespace TranslateToRobberLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input and get it repeated: ");
                string input = Console.ReadLine();

                if (input == "ping") 
                {
                    string pong = Translator.Ping();
                    Console.WriteLine(pong);
                    continue;    
                }

                Console.WriteLine(input);
            }
        }
    }
}
