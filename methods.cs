using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main()
        {
            int[]x = { 1, 2, 3 };

            Increment(ref x);

            Console.Write("\nx: \t");
            foreach (int i in x)
            {
                Console.Write(i + " ");
            }
        }

        static void Increment(ref int[]a)
        { 
            for(int i=0; i < a.Length; i++)
            {
                a[i]++;
            }

            a = new int[5];

            Console.Write("a: \t");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

        }

    }
}
