using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {

        //public static Drinks drinks { get; }
        static void Main(string[] args)
        {
            
            DisplayMenu Menu = new DisplayMenu();
            Menu.MenuOptions();
            SelectionMenuOption selectionMenu = new SelectionMenuOption();
            selectionMenu.Select();

        }
    }
}
