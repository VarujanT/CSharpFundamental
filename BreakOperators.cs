using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BreakOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter A,B or C");
            char tar = char.Parse(ReadLine());
            switch(tar)
            {
                case 'A':
                    WriteLine((int)'A');
                    return;
                case 'B':
                    WriteLine("Bari Luys");
                    break;
                case 'C':
                    WriteLine("Console Color");
                    
                    goto case 'A';
            }
        }
    }
}