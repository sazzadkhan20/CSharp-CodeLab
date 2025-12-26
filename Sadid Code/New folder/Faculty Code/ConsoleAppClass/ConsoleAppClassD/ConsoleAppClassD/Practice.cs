using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassD
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            /*int[] ax = new int[5] { 23, 56, 22, 100, -87 };
             ax[0] = 90;*/

            //While loop reverse order
            //int a = 10;
            //while(a>=1)
            //{
            //    Console.WriteLine("{0}",a);
            //    a--;
            //}

            //Print array using for loop
            //int[] ax = new int[5] { 23, 56, 22, 100, -87 };
            //for (byte c = 0; c < 5; c++)
            //{
            //    Console.Write("{0} ", ax[c]);
            //}
            //Console.WriteLine();

            //Print array using while loop
            /*int[] ax = new int[] { 23, 56, 22, 100, -87 };
            int d = 0;
            while (d < ax.Length)
            {
                Console.Write("{0} ", ax[d]);
                d++;
            }
            Console.WriteLine();*/

            //Print array in reverse order using while loop
            /* int[] ax = new int[] { 23, 56, 22, 100, -87 };
             int d = ax.Length - 1; 
             while (d >= 0)
             {
                 Console.Write("{0} ", ax[d]);
                 d--;
             }
             Console.WriteLine();*/

            //Print array using do while loop
            //int[] ax = new int[] { 23, 56, 22, 100, -87 };
            //int d = 0;
            //do
            //{
            //    Console.Write("{0} ", ax[d]);
            //    d++;
            //}
            //while (d < ax.Length);
            //Console.WriteLine();


            int[][,] array = new int[3][,];
            array[0] = new int[,] { { 1,2,4}, { 3,4,5} };
            array[1] = new int[,] { { 6, 7 }, { 8, 9 }, { 10, 11 }, { 12, 13 } };
            array[2] = new int[,] { { 100, 456 }, { 121, 644 } };

            int i, row, column;

            i = 0;
            while (i < array.Length)
            {
                row = 0;
                while(row < array[i].GetLength(0))
                {
                    column = 0;
                    while (column < array[i].GetLength(1))
                    {
                        Console.Write("{0} ", array[i][row, column]);
                        column++;
                    }
                    row++;
                    Console.WriteLine();
                }
                i++;
                Console.WriteLine();
            }

        }
    }
}
