using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("The factorial of " +number +" is "+ factorial_Recursion(number));

        }

        public static double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }
    }
}