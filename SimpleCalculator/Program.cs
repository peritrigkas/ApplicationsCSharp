using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = " Here is some Text";
            int number = 10;
            double anotherNumber = 10.9;
            bool isOrdered = true;
            string input = Console.ReadLine();
            var anything = 10.9;
            Console.WriteLine(someText);
            Console.WriteLine(number);
            Console.WriteLine(anotherNumber);
            Console.WriteLine(isOrdered);
            Console.WriteLine(input);
            Console.WriteLine(anything);
            int c;
            int.TryParse(input, out c);

            Console.WriteLine(10 - 9 + c);


            string someTexts = " Here is some text";
            string someOtherText = "Here is some other text";

           bool isEqueal = someTexts.Equals(someOtherText, StringComparison.Ordinal); // makes char by char comparison
                                                                                      // currentCulture takes into consideration user's location
        }
    }
}
