using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class DisplayMenu
    {
       public static Drinks Drinks { get; }
        public void MenuOptions()
        {        
            foreach(var drink in Enum.GetNames(typeof(Drinks)))
            {
                //Console.WriteLine("{0} = {1:D}", drink,
                                         //Enum.Parse(typeof(Drinks), drink));
               Console.WriteLine("**       {0}     ",drink); 
               Console.WriteLine("*******************");
            }
        }
    }
}
