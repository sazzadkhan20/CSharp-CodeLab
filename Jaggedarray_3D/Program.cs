using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaggedarray_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] arr1 = new int[3][,]
            {
                new int[,]{{3,5},{1,4},{2,1}},
                new int[,]{ { 1, 1 } ,{5,6},{ 8,9} },
                new int[,]{{0,1},{0,3},{ 10,11},{ 12,15} }
            };

            Console.WriteLine(arr1[0][1, 0]);
            /*for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].GetLength(0); j++)
                {
                    for (int k = 0; k < arr1[j].GetLength(1); k++)
                    {
                        Console.WriteLine(arr1[i][j, k]);
                    }
                }
            }*/


            Console.ReadKey();
        }
    }
}
