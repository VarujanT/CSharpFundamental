using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CompoundAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int sum = 0;
            int fact = 1;
            for (int i=1; i<13; i++)
            {
                x /= i;
                sum += (int)(Math.Cos(x) + Math.Pow(i, 3));
                fact *= i;
            }
            WriteLine("x = " + x + ("\nSum =" + sum + "\nfact =" + fact));
        }
    }
}