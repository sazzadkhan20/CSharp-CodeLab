using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_check_function
{
    class Program
    {
        public void fun()
        {
             for(int i=0; i<5; i++)
            {
                
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            /*  for (int i = 0; i <= 10; i++)
              {
                  int sum = p.fun(i, i);
                  if (sum % 2 == 0)
                      Console.WriteLine("Summation : " + sum);
                  else Console.WriteLine("No Summation");
              }*/
            p.fun();
            Console.Read();
        }
    }
}
