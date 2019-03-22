using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = /*new int[]*/ { 5, 7, -21, 22, -30, 8 };
            for (int i = 0; i < a.Length; i++) 
            {
                Write(a[i] + "\t");
            }
            WriteLine();

            DateTime[] dt;
            dt = new DateTime[] { DateTime.Now, new DateTime(2018, 7, 8) };
            for(int i = 0; i<dt.Length; i++)
            {
                WriteLine(dt[i]);
            }

            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            WriteLine("Sum=" + sum);
            WriteLine(sum / a.Length);
        }
    }
}