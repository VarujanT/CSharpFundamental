using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Array_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            do
            {
                Write("Enter Array Size...");
                int n = int.Parse(ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rd.Next(-99, 100);
                    Write(a[i] + "\t");
                }
                WriteLine("Press Enter To Continue");
            } while (ReadKey().Key == ConsoleKey.Enter);
        }
    }
}