using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             // create array 

            int[] x = new int[10];

             // acccessing array elements 

             x[3] = 5;

             // array literal

             string[] cars = { "fiat", "nissan", "bmw" };

             Console.WriteLine("cars[0]: " + cars[0]);
             Console.WriteLine("cars[1]: " + cars[1]);
             Console.WriteLine("cars[2]: " + cars[2]);

             Console.WriteLine("length = " + cars.Length);

             // arrays and loops 

             float[] m = new float[5];

             for (int i = 0; i < 5; i++)
             {
                 Console.Write("value" + (i + 1) + ": ");
                 m[i] = float.Parse(Console.ReadLine());
             }

              float sum = 0;
             for (int i = 0; i < 5; i++)
             {
                 sum += m[i];
             }

             for (int i = 0;i < 5; i++)
             {
                 Console.Write(" + " + m[i]);
             }
             Console.WriteLine(" = " + sum);

             // foreach loop 

             foreach (string car in cars) 
             {
                 Console.WriteLine(car);
             }

             // copying arrays 

             int[] v = { 1, 2, 3, 4, 5 };
             int[] y = v;// copy the reference
             y[1] = 70;

             Console.WriteLine("v: ");
             for (int i =0; i < 5; i++)
             {
                 Console.Write(v[i]);
             }

             Console.WriteLine();

             Console.WriteLine("y: ");
             for (int i = 0; i < 5; i++)
             {
                 Console.Write(y[i]);
             }

             // no effect

             int[] b = { 1, 2, 3, 4 };
             int[] s = new int[4];

             for (int i =0; i <5; i++)
             {
                 s[i] = b[i]; // copy elements
             }

             s[1] = 0;

             Console.WriteLine("b: ");
             for (int i = 0; i < 5; i++)
             {
                 Console.Write(b[i]);
             }

             Console.WriteLine();

             Console.WriteLine("s: ");
             for (int i = 0; i < 5; i++)
             {
                 Console.Write(s[i]);
             }

             // multidimensional arraysintintint

             int[,] d = new int[4, 2];
             int[,,] f = new int[4, 2, 7];

             int[,] g = { { 11, 12, 13 }, { 21, 22, 23 },
                 { 31, 32, 33 }, { 41, 42, 43 } };

             for (int row = 0;row < 4; row++)
             {
                 for(int col = 0; col < 3; col++)
                 {
                     Console.WriteLine(g[row, col] +"/t");
                 }
                 Console.WriteLine() ;
             }

             int[,,] h = { {{ 11, 12, 13 }, { 21, 22, 23 } } ,
                 { { 31, 32, 33 }, { 41, 42, 43 } } };

             Console.WriteLine(h[0,1,2]) ;
             Console.WriteLine(h[1,0,1]) ;
             

            //program 

            Console.WriteLine("rows :");
            int rows =int.Parse(Console.ReadLine());

            Console.WriteLine("cols : ");
            int cols =int.Parse(Console.ReadLine());

            
            Console.WriteLine("first matrix: ");
            double[,] j = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write("[{0},{1}]", i, c);
                    j[i, c] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("second matrix: ");
            double[,] k = new double[rows, cols];

            for(int i = 0;i < rows; i++)
            {
                for(int c = 0;c < cols; c++)
                {
                    Console.Write("[{0},{1}]", i, c);
                    k[i, c] = double.Parse(Console.ReadLine());
                }
            }

            for(int i =0; i<rows; i++)
            {
                for(int c = 0;c<cols; c++)
                {
                    double sumS = j[i,c] + k[i,c];
                    Console.WriteLine(" THE SUM IS: " + sumS);
                }
            }






        }
    }
}