sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace  TernaryconditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Two Integers");
            int x = int.Parse(ReadLine());
            int y = int.Parse(ReadLine());
            int z = int.Parse(ReadLine());
            WriteLine("Max=" + (x > y ? (x > z ? x : z) : (y > z) ? y : z));
        }
    }
}