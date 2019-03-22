using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinaryExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter Bin Expression");
            double n1 = double.Parse(ReadLine());
            char op = char.Parse(ReadLine());
            double n2 = double.Parse(ReadLine());
            double result = 0;
            if (op =='+')
            {
                result = n1 + n2;
            }
            else if (op == '-')
            {
                result = n1 - n2;
            }
            else if(op=='/')
            {
                result = n1 / n2;
            }
            else if (n2!=0)
            {
                WriteLine(result);
            }
        }
    }
}