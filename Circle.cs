using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;



namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Write("Enter Radius...");
                int radius = int.Parse(ReadLine());
                if (radius > Math.Min(WindowWidth / 2, WindowHeight / 2))
                continue;
                for (int x = -radius; x <= radius; x++)
                {
                    int y = (int)Sqrt(Pow(radius, 2) - Pow(x, 2));
                    int x1 = x + WindowWidth / 2;
                    int y1 = y + WindowHeight / 2;
                    SetCursorPosition(x1, y1);
                    WriteLine("*");

                }
            } while (ReadKey().Key == ConsoleKey.Enter);
        }
    }
}