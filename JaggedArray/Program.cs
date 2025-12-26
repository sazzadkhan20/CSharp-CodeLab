using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[0];

            Console.Write("\nOutput Array : ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(" " + jaggedArray[i][j]);
                }
            }
            Console.ReadLine();
            /*Console.Write("Input Main Array Size : ");
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Input In Order " + i + " Array Size : ");
                int m = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[m];
                for (int j = 0; j < m; j++) jaggedArray[i][j] = int.Parse(Console.ReadLine());

            }
            Console.Write("\nOutput Array : ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
                {
                    Console.Write(" " + jaggedArray[i][j]);
                    if (j == 0) jaggedArray[i][j] = 100;
                }
            }
            Console.Write("\nUpdated Arry : ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
                    Console.Write(" " + jaggedArray[i][j]);
            }
            Console.ReadLine();
        }*/
        }
    }
}
