using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintsWeekDaysWithForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysofweek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            /*string[] s = new string[5] ;
            s[0] =  "Monday";
            s[1] = "Tuesday";
            s[2] = "Wednesday";
            s[3] = "Thursday";
            s[4] = "Friday";
            */
            for (int i = 0; i < daysofweek.Length; i++)
            {
                Console.WriteLine(daysofweek[i]);
            }
        }
    }
}

