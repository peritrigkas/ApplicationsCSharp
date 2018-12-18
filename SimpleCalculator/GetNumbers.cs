using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class GetNumbers
    {
        private int _argSecondNumber;

        public  string argOperator;
        public  int argFirstNumber { get; set; }
        public  int argSecondNumber
        {
            get
            {
                return _argSecondNumber;
            }

            set
            {
                try

                {
                    if ((value == 0 && argOperator == "/")|| (value == 0 && argOperator == "divide"))
                    {
                        throw new DivideByZeroException("Zero values are not acceptable");
                    }
                   else if (value != 0)
                            _argSecondNumber = value;
                    
                }
                catch (Exception exmsg)
                {
                    do
                    {
                        Console.WriteLine("You can not DIVIDE by ZERO!!! ");
                        Console.Write("Enter 2nd Number AGAIN: ");
                        _argSecondNumber = int.Parse(Console.ReadLine());
                        //Console.WriteLine("You entered {0} as the 2nd Number", _argSecondNumber);
                        //_argSecondNumber = value;

                    } while (_argSecondNumber == 0);
                   
                }

           
            }
        }

        public GetNumbers()
        {
            Console.Write("Enter Operator {+,-,/,* or use add, subtract, mulitply,divide: ");
            argOperator = Console.ReadLine();
            Console.WriteLine("You entered the {0} Operator",argOperator);

            Console.Write("Enter 1st Number: ");
            argFirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0} as the 1st Number", argFirstNumber);

            Console.Write("Enter 2nd Number: ");
            argSecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered {0} as the 2nd Number", argSecondNumber);

        }
        

    }
}
