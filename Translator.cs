using System;

namespace TranslateToRobberLanguage
{
    public static class Translator
    {
        public static string RobberLanguage(string input)
        {
            string lowerCasedInput = input.ToLower();

            string translation = "";
            
            char[] consonants = Helper.GetAllConsonants();

            char[] inputChars = lowerCasedInput.ToCharArray();

            foreach (char inputChar in inputChars)
            {
                if (Array.Exists(consonants, c => c == inputChar))
                {
                    translation += inputChar + "o" + inputChar;
                    continue;
                }

                translation += inputChar;
            }

            return translation;
        }
    }
}
