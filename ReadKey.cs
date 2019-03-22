using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Readkey
{
    class Program
    {
        static void Main(string[] args)
        { Random rd = new Random();
            WriteLine("Method Readkey");
            ConsoleKeyInfo keyInfo = ReadKey();
            ConsoleKey key = keyInfo.Key;
            while(key==ConsoleKey.Escape)
            {
                int x = rd.Next(0, WindowWidth - 1);
                int y = rd.Next(WindowHeight - 1);
                ForegroundColor = (ConsoleColor)rd.Next(1, 16);
                SetCursorPosition(x, y);
                WriteLine("*");
                WriteLine("Press Esc To Continue");
                key = ReadKey().Key;
            }
        }
    }
}