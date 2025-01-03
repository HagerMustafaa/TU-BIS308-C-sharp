using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // model 1
            int[] x = { 22, 30, 44, 29, 17, 14 };
            int sum1 = 0;

            for (int m=0; m<x.Length; m++)
            {
                if (x[m] % 2 == 0)
                {
                    sum1 += x[m];
                }
            }
            Console.WriteLine(sum1);

            // model 2
            int sum2 = 0;
            for(int m=0; m <= 10; m++)
            {
                if(m == 7)
                {
                    continue;
                }
                sum2 += m;
            }
            Console.WriteLine(sum2);

            // model 3
            for(int m = 5; m <= 50; m +=5)
            {
                if(m == 15)
                {
                    continue;
                }
                Console.Write(m + " ");
            }
            Console.WriteLine();

            // model 4
            int[] y = new int[5];
            for (int m = 0; m< y.Length; m++)
            {
                Console.Write("Enter a number" + m + ": ");
                y[m] = int.Parse(Console.ReadLine());
            }
            for(int m = 0; m < y.Length; m++)
            {
                Console.Write(y[m] + " ");
            }
            Console.WriteLine();

            // model 5
            int[] z = { 25, 26, 27, 28, 29, 30 };
            for(int m = 0; m < z.Length; m++)
            {
                if (z[m] % 5 == 0)
                {
                    Console.Write(z[m] + " ");
                }
            }
        }
    }
}
