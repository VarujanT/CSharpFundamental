using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int x = rd.Next(-10, 11);
            int count = 1;
            while(x!=0)
            {
                Console.Write(count);
                Console.WriteLine("\t" + Math.Pow(x, 2));
                count = count + 1;
                x = rd.Next(-10, 11);
            }
            Console.WriteLine("Finish");


            Console.WriteLine("Enter integer...");
            int n = int.Parse(Console.ReadLine());
            int digitCount = 0;
            //while (n!=0)
            do
            {
                n = n / 10;
                digitCount = digitCount + 1;
            }
            while (n != 0);
            Console.WriteLine("Digit count is" + digitCount);
        }
    }
}