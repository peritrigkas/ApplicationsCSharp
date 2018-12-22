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
            GetNumbers getNumbers = new GetNumbers();
            CalculatorEngine calculate = new CalculatorEngine();
            double result = calculate.result;
            double result2 = calculate.Calculate(getNumbers.argOperator, getNumbers.argFirstNumber, getNumbers.argSecondNumber);
            Console.WriteLine("{0} {1} {2} equals {3}", getNumbers.argFirstNumber,getNumbers.argOperator, getNumbers.argSecondNumber, result2);
            Console.ReadKey();
        }
    }
}
