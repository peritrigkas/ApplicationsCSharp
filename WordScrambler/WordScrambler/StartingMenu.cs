using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScrambler
{
    class StartingMenu
    {

        public void FileInputOption()
        {
            bool continueWordUnscrambler = true;

            do
            {
                Console.Write("Please enter the Option - F for file and M for Manual :");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name :");
                        ExecuteScrambledWord.InFileScenario();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually :");
                        ExecuteScrambledWord.ManualScenario();
                        break;
                    default:
                        Console.WriteLine("Option is not recognised");
                        break;
                }

                var continueDecision = string.Empty;

                do
                {
                    Console.Write("Do you want to continue the program?");
                    continueDecision = (Console.ReadLine() ?? string.Empty);

                } while (!continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase));


                continueWordUnscrambler = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);



            } while (continueWordUnscrambler);
        }
    }
}
