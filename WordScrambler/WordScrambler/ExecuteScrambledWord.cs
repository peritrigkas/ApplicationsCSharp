using System;

namespace WordScrambler
{
     class ExecuteScrambledWord
    {
        public static void ManualScenario()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[]  scrambledWords = manualInput.Split(',');
            DisplayWords.DisplayMatchedUnscrambledWords(scrambledWords);
        }

        public static void InFileScenario()
        {
            var filename = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = DisplayWords._fileReader.Read(filename);
            DisplayWords.DisplayMatchedUnscrambledWords(scrambledWords); 

        }

        
    }
}