using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExamplePrg
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());
            bool repeat = false;
            while (num != 0) 
            {
                int last = num % 10;
                int mnacac = num / 10;
                while(mnacac != 0)
                {
                    int lastmnacac = mnacac / 10;
                    if (last == lastmnacac)
                    {
                        repeat = true;
                        break;
                        WriteLine();
                        ReadKey();
                        break;
                    }mnacac = mnacac / 10;

                }
                if (repeat == true)
                    break;
                    num = num / 10;
            }
            WriteLine(repeat == true ? "Krknvogh ka" : "Krknvogh Chka"); 
        }
    }
}