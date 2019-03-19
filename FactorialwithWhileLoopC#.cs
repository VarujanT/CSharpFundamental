using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0, factorial = 0, counter = 0;

            Console.WriteLine("Enter a positive integer");
            number = int.Parse(Console.ReadLine());

            factorial = number;
            counter = number - 1;

            while (counter > 0)
            {
                factorial *= counter;
                counter--;
            }

            Console.WriteLine("Factorial of {0:N0} is {1:N0}", number, factorial);
            Console.ReadLine();


        }
    }
}

