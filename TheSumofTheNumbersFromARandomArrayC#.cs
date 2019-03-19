using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsTheMinumumAndMaximumNumbersofARadnomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            int[] line = new int[100];

            for (int i = 0; i < line.Length; i++)
            {
                line[i] = rd.Next(-100, 101);
                Console.WriteLine(line[i]);
            }
            int min = line[0];
            int max = line[0];
            for (int i = 1; i < line.Length; i++)
            {
                if (line[i] < min) min = line[i];

                if (line[i] > max) max = line[i];

            }
            Console.WriteLine("\n" +"The minumum is:" + min);
            Console.WriteLine("The maximum is: " + max);

        }
    }
}