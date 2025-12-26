using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    public class B
    {
        private protected int a;
        public int b;

    }
    public class A : B
    {
        string i;
        private protected int d;
        public int e;
        public void N()
        {
            this.a =10;
        }
    }

    class Program: A
    { 
        public static void display1(ref int x)
        {
            Console.WriteLine(x);
            x = 100;
        }
        public static int display3(in int x)
        {
           // x = 10;
            return x; 
        }
        public static int display2(out int y)
        {
            y = 1000;
            return y;
        }
            static void Main(string[] args)
            {
                int[][] jagged = new int[4][];
                jagged[0] = new int[] { 1,3,5,7,9,11,13,15 };
                jagged[1] = new int[3]; //{4,0,4}
                jagged[2] = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
                jagged[3] = new int[3];//{12,0,20}

                for (int row = 0; row < 4; row += 2)
                {
                    for (int column = 0; column < jagged[row].Length; column += 3) 
                    {
                        Console.Write("{0} ",jagged[row][column]); // 1 7 13
                    //2 8 14
                    }
                    Console.WriteLine();
                }

                for (int index = 0; index < jagged[1].Length; index += 2)
                {
                    jagged[1][index] = jagged[0][index + 2] - jagged[0][index];
                }

                for (int index = 0; index < jagged[3].Length; index++)
                {
                    jagged[3][index] = jagged[2][index++ ] + jagged[2][index + 3];
                }

                for (int row = 1; row < 4; row += 2)
                {
                    for (int column = 0; column < jagged[row].Length; column += 2)
                    {
                        Console.Write("{0} ",jagged[row][column]); // 4 4
                    //12 20
                    }
                    Console.WriteLine();
                }
            int i, j = 1, k;
            for (i = 0; i < 5; i++)
            {
                k = j++ + ++j;
                Console.Write(k + " ");
            }
            Console.ReadLine();
            }
        }

        /*int a = 10, b = 20;
        display1(ref a);
        display2(out b);
        Console.WriteLine(a + " " + b);
        int[] arr = new int[] { 1, 2, 3 };
        Console.ReadLine();*/
}
