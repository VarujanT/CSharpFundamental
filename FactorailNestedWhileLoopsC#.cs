using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorailNestedWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial;
            int index = 1;
            int counter = 0;

            Console.WriteLine("Number\tFactorial");
            while (index <= 5)
            {
                factorial = 1;
                counter = index;
                while(counter > 0)
                { 
                    factorial *= counter;
                    counter--;
                }
                Console.WriteLine(index + "\t" + factorial);
                index++;
            }

            Console.ReadLine();
        }
    }
}