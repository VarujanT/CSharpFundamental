using System;
using static System.Console;

namespace CardGame
{
    class Program
    {
        public enum Faces
        {
            T = 10,
            J = 11,
            Q = 12,
            K = 13,
            A = 14
        }
        static void Main()
        {
            Random rd = new Random();
            do
            {
                Clear();
                int[][] deck = new int[24][];
                int count = 0;
                for (int i = 3; i < 7; i++)
                {
                    for (int j = 9; j < 15; j++)
                    {
                        deck[count++] = new int[] { i, j };
                    }
                }
                for (int i = 0; i < deck.Length; i++)
                {
                    int rand = rd.Next(deck.Length);
                    int[] temp = deck[rand];
                    deck[rand] = deck[i];
                    deck[i] = temp;
                }
                int top = 3;
                int left = (WindowWidth - 4 * 5) / 2;
                for (int i = 0; i < 8; i++)
                {

                    if (i == 4)
                    {
                        top = WindowHeight - 7;
                        left = (WindowWidth - 4 * 5) / 2;
                    }
                    SetCursorPosition(left, top);
                    Write("#--#");
                    SetCursorPosition(left, top + 1);
                    Write("|");

                    Write((char)deck[i][0]);

                    if (deck[i][1] < 10)
                        Write(deck[i][1]);
                    else
                        Write((Faces)deck[i][1]);
                    Write("|");
                    SetCursorPosition(left, top + 2);
                    Write("#--#");
                    left += 5;
                }
            } while (ReadKey().Key == ConsoleKey.Enter);
        }
    }
}