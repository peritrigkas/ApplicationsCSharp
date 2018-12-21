using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscrambler = true;

            do
            {
                Console.WriteLine("Please enter the Option - F for file and M for Manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.WriteLine("Enter scrambled words file name :");
                        ExecuteScrambledWord.InFileScenario();
                        break;
                    case "M":
                        Console.WriteLine("Enter scrambled words manually :");
                        ExecuteScrambledWord.ManualScenario();
                        break;
                    default:
                        Console.WriteLine("Option is not recognised");
                        break;
                }
                var continueWordUnscrambleDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue the program?");

                } while (!continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueWordUnscrambleDecision.Equals("N", StringComparison.OrdinalIgnoreCase));
            } while ();

         
        }

        
    }

   
}
