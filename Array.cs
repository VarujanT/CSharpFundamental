using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] a = new int[5];// a[2] = 20;// Writeline (a[2]);
            for (int i = 0; i < a.Length; i++)
            {
                Write(a[i] + "\t");
            }
            WriteLine();

            Write("Enter Color Count");
            int n = int.Parse(ReadLine());
            ConsoleColor[] colors = new ConsoleColor[n];
            for (int i = 0; i < colors.Length; i++)
            {
                colors[i] = (ConsoleColor)rd.Next(16);
            }
            WriteLine();
            for (int i = 0; i < colors.Length; i++)
            {
                BackgroundColor = colors[i];
                Write(" ");
            }
            //////////miachap zangvacner///////////

            int[] x = new int[200];
            int[] y = new int[200];

            for(int i=0; i<x.Length;i++)
            {
                x[i] = rd.Next(0, WindowWidth);
                y[i] = rd.Next(0, WindowHeight);
            }
            for (int i = 0; i < x.Length; i++)
            {
                SetCursorPosition(x[i], y[i]);
                ForegroundColor = (ConsoleColor)rd.Next( 16);
                BackgroundColor = (ConsoleColor)rd.Next(16);

                Thread.Sleep(50);
                Write("*");
            }
        }
    }
}