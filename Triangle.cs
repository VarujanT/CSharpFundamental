using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            do
            { Write("Enter Triangle Page...");
                int a = int.Parse(ReadLine());//WriteLine ("*");
                for (int i = 0; i < a; i++)
                {
                    ForegroundColor = (ConsoleColor)rd.Next(1, 16);
                    Write("*");
                    for (int k = 0; k < i; k++)

                        if (i == a - 1)
                        {
                            Write("*");
                        }
                        else
                        {
                            Write(" ");
                        }

                    ForegroundColor = (ConsoleColor)rd.Next(1, 16);
                    WriteLine("*");
                    ResetColor();
                }
            } while (ReadKey().Key == ConsoleKey.Enter) ;          
        }
    }
}