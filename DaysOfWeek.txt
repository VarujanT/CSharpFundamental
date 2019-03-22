using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Shabatva_orer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            skizb: int patahakan = rd.Next(0, 16);
            WriteLine("\n\nNermucel 1-7 tiv");
            int day = int.Parse(ReadLine());
            switch(day)
            {
                case 1:
                    ForegroundColor =(ConsoleColor) patahakan;
                    WriteLine("Erkushabti");
                    break;
                case 2:
                    ForegroundColor = (ConsoleColor)patahakan;
                    WriteLine("Ereqshabti");
                    break;
                case 3:
                    ForegroundColor = (ConsoleColor)patahakan;
                    WriteLine("Choreqshabti");
                    break;
                case 4:
                    ForegroundColor = (ConsoleColor)patahakan;
                    WriteLine("Hingshabti");
                    break;
                case 5:
                    ForegroundColor = (ConsoleColor)patahakan;
                    WriteLine("Urbat");
                    break;
                case 6:
                    ForegroundColor = (ConsoleColor)patahakan;
                    WriteLine("Shabat");
                    break;
                case 7:
                    ForegroundColor = (ConsoleColor)patahakan;
                    WriteLine("Kiraki");
                    break;
                default:
                    ForegroundColor = (ConsoleColor)patahakan;
                    WriteLine("Vecshabti");
                    break;
            }
            ResetColor();
            goto skizb;
        }   
    }
}