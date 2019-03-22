using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Width =" + Console.WindowWidth);
            Console.WriteLine("Height =" + Console.WindowHeight);
            Thread.Sleep(2000);
            Console.WindowWidth = Console.WindowWidth + 10;
            Thread.Sleep(1000);
            Console.WindowHeight = Console.WindowHeight + 5;
            WriteLine(CursorLeft + "," + CursorTop);
            Thread.Sleep(1000);
            SetCursorPosition(WindowWidth / 2, WindowHeight / 2);
            WriteLine(WindowWidth + "," + WindowHeight);
        }
    }
}