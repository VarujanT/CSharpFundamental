using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CountingFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            long fct = 1;
            int i=2;

            for (; ;) 
            {
                if (i > n) break; //i <= n;
                {
                    fct = fct * i;
                    i = i + 1;
                }
                
            }
            WriteLine(n + " Factorial " + fct);
            for (int k = 2, fact = 1; k <= n; k = k + 1, fact = fact * k, WriteLine(fact)) ;
        }   
    }
}