using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ColourfulSwitch
{
    class Program
    {
        static void Main(string[] args)
        { Random rd = new Random();
            int color = rd.Next(1,16);
            WriteLine("Random Num is " + color);
            ConsoleColor clr;
            switch(color)
            {
                case 1:
                    ForegroundColor = (ConsoleColor)1;
                    WriteLine((ConsoleColor)1);
                    break;
                case 2:
                    ForegroundColor = (ConsoleColor)2;
                    WriteLine((ConsoleColor)2);
                    break;
                default:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine(ConsoleColor.Red);
                    break;
            }
        }
    }
}