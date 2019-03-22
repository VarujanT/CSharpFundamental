using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariphm_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1000000;
            int b = 10000;
            
           // checked//
            {
                int d = a + b;
                Console.WriteLine(d);
                int c = a - b;
                Console.WriteLine(c);
            }
            int x = 10;
            int y = 3;
            // double z =(double)y/x;//
            //Console.WriteLine(z);//
            int mne = y % x;
            Console.WriteLine(mne);
            //bool b = 15;//
            //int a = (int) 0.5;//


        }
    }
}