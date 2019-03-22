using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            WriteLine("Press Enter To Start");
            while (ReadKey(). Key == ConsoleKey.Enter)
            {
                WriteLine("Enter Rect Sizes");
                int w = int.Parse(ReadLine());
                int h = int.Parse(ReadLine());
                for (int i=0; i<h; i=i+1)
                {
                    Write("*");
                    for (int k = 0; k < w; k = k + 1)// k < w - 2;
                    {
                        if (i==0 || i==h-1)
                        {
                            Write("*");
                        }
                        else
                        {
                            Write(" ");
                        }
                    }
                    WriteLine("*");
                }

            }

        }
    }
}