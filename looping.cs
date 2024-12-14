using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* while */

            int counter = 1;

            while (counter <= 5)
            {
                Console.Write(counter + " ");
                counter++;
            }
             /* infinite */
            while (counter <= 5)
            {
                Console.Write(counter + " ");
            }

            /* do..while */

            int score;

            do
            {
                Console.Write("enter (0:100): ");
                score = int.Parse(Console.ReadLine());
            }
            while (score < 0 || score > 100);

            Console.WriteLine("accepted!");

            /* for..loop */

            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (int i = 1; i < 10; i+=2)
            { 
                Console.Write(i + " ");
            }

            Console.WriteLine();

            /* break statement */

            /* continue statement */

            float sum = 0;

            for (int i = 1; i <=5; i++)
            {
                Console.Write("enter number ("+ i +") : ");
               float n = float.Parse(Console.ReadLine());
                if (n == 0) break;
                if (n < 0) continue;
                sum += n;
            } 

            Console.WriteLine("\n sum = " + sum);

            /* nested loops */
           
            for (int l = 1; l <= 10; l++)
            {
                for (char c = 'A'; c <= 'E'; c++)
                {
                    Console.Write(c +" ");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <=5; row++)
            {
                for(int col = 1; col<=5; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }


            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (int row = 5; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            /* prime num*/

            for (int n = 2; n <= 30; n++)
            {
                bool isPrime = true;
                int max = n / 2;

                for (int i = 2; i < max; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(n + " "); 
                }
               
            }











        }
    }
}
