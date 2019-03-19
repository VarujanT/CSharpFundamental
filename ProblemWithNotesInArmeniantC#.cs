using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFromMICTest
{
    class Program
    {
        static void Main(string[] args)
        {
			//Console - ից մուտքագրել int տիպի x և y թվերը։ Հաշվել  x/y հարաբերության  ամբողջ մասը և արդյունքը վերագրել n փոփոխականին։ 
            //Հաշվել  x/y  հարաբերության մնացորդը եւ արդյունքը վերագրել r  փոփոխականին։ 
            //Console - ում տպել  n * y + r - x արտահայտության արժեքը և համոզվել, որ այն հավասար է 0-ի։
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int n = x / y;
            int r = x % y;


            Console.WriteLine(n * y + r - x);
            if (n * y + r - x == 0)
            {
                Console.WriteLine("true");
            }
        }
    }
}

