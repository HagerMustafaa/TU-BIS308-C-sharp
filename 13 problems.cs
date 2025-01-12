using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_problems
{
    class Problem1
    {
        // problem 1
         static void Main(string[] args)
         {
             Console.WriteLine("Enter a number 1: ");
             int num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter a number 2: ");
             int num2 = int.Parse(Console.ReadLine());

             Console.WriteLine("The sum is " + AddNumbers(num1, num2));

         }
         static int AddNumbers(int a, int b)
         {
             return a + b;
         }
    }
    class Problem2
    {

        // problem 2
         static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (IsEven(num))
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
         static bool IsEven(int number)
             {

                 return number % 2 == 0;
             }
    }
    class Problem3
    {

        // problem 3
        static void Main()
        {
         Console.WriteLine("Enter a number: ");
         int num = int.Parse(Console.ReadLine());

         PrintTable(num);
        }
        static void PrintTable(int number)
        {
         for (int i =1; i <= 10; i++)
         {
            int result = number * i;
            Console.WriteLine("{0} * {1} = {2}",number,i,result);

         }
        }
    }
    class Problem4
    {
        // problem 4
        static void Main()
        {
        Console.WriteLine("enter your name: ");
        string name = Console.ReadLine();
        GreetUser(name);
        }
       static void GreetUser(string name)
       {
        Console.WriteLine("Hello " + name);
       }
        
        
    }
    class Problem5
    {
        // problem 5
        static void Main()
        {
            Console.WriteLine("Enter length : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width : ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("the area is " + CalculateArea(num1, num2));
        }
        static double CalculateArea(double a, double b)
        {
            return a * b;
        }
    }
    class Problem6
    {
        // problem 6
        static void Main()
        {
            CountToTen();
        }
        static void CountToTen()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Problem7
    {
        // problem 7
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            CheckPositive(num);
        }
        static void CheckPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
    }
    class Problem8
    {
        // problem 8
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyByTwo(num));
        }
        static int MultiplyByTwo(int number)
        {
            return number * 2;
        }
    }
    class Problem9 
    {
        // problem 9
        static void Main()
        {
        int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        CountEvenNumbers(x);
        }
        static void CountEvenNumbers(int[] a)
        {
        int count = 0;
        foreach (int i in a)
        {
            if (i % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);

        }
    }
    class Problem10To13
    {


        static void Main()
        {
            // problem 10
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();

            // problem 11
            int[] y = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int i = 0; i < y.Length; i++)
            {
                sum += y[i];
            }
            Console.WriteLine(sum);

            // problem 12
            int[] z = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = z.Length - 1; i >= 0; i--)
            {
                Console.Write(z[i] + " ");

            }
            Console.WriteLine();

            // problem 13
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 7)
                {
                    continue;
                }
                Console.Write(a[i] + " ");
            }
        }



    }

    
}
