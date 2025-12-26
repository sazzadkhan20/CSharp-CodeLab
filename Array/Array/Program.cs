using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[][] myja = new int[4][];
            myja[0] = new int[5] { 1, 3, 6, 5, 2 };
            myja[3] = new int[1];
            myja[1] = new int[2] { 9, 8 };
            myja[2] = new int[5] { 2, 1, 6, 3, 4 };
            for (int i = 0; i < myja[0].Length; i++)
            {
                myja[3][c] = myja[0][i];
            }
           Console.WriteLine(myja[3][c]);
            for (int i = 0; i < myja[2].Length; i++)
            {
                myja[3][c] += myja[0][i] + myja[2][i];
            }
            Console.WriteLine(myja[3][c]);
            Console.WriteLine(myja[3][c] - myja[1][1]);
            Console.WriteLine(myja[1][0] - myja[2][2]);
            Console.ReadKey();

            /* Console.Write("Enter array Size: ");
             int n = int.Parse(Console.ReadLine());
             int []arr = new int[n];
             int sum1 = 0,sum2 = 0;
             for(int i=0; i<n; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
                 if (i < n/2) sum1 += arr[i];
                 else sum2 += arr[i];
             }
             //foreach (int x in arr) Console.WriteLine(x);
             Console.Write("\nSubstraction : "+(sum1-sum2));*/
        }
    }
}
