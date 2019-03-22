using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace IfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter integer");
            int a = int.Parse(ReadLine());
            if (a > 0)
            {
                WriteLine(a * a * a);
            }
            else
            {
                WriteLine(a * a);
            }
        }  
    }
}