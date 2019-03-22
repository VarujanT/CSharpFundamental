using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Demo_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            return;   Random rd = new Random();
            int x = rd.Next(10, 14);
            switch(x)
            {
                case 10:
                case 12:
                    WriteLine(Math.Pow(x, 3));
                    break;
                case 11:
                    WriteLine(Math.Pow(x, 2));
                    break;
                case 13:
                    goto case 11;
            }

        }
    }
}