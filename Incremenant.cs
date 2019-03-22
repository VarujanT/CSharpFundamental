using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Incremenant
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 10;
             x++;
             Console.WriteLine(x);
             ++x;
             Console.WriteLine(x);
             WriteLine(x++);
             WriteLine(++x);*/

            int sum = 0;
            for(int i=0; i<10; ++i)
            {
                //++sum;       //sum = sum + 1;
                WriteLine(sum++);

            }
            int x = 10;
            int y = ++x;//x=11;y=11
            int z = y++;//z=11;y=12
            
            //x=11;y=12;z=11
            WriteLine((x++) + "\t" + (++y) + "\t" + (z++));
            //x=12;y=13;z=12;
            WriteLine(x + "\t" + y + "\t" + z);
        }
    }
}