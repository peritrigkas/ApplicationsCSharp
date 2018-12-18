using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{   
    class CalculatorEngine
    {
        public double result;
        public double Calculate(string argOperator,double argFirstNumber,double argSecondNumber)
        {
            switch (argOperator.ToLower())
            {
                case          "+":
                case        "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case          "/":
                case     "divide":
                    result = argFirstNumber / argSecondNumber;
                    break;
                case          "-":
                case   "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case          "*":
                case   "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;

            }
               return result;
            
        }

       
    } 
}
