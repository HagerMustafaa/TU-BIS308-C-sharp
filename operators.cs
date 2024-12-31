using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arithmetic operators
            int a = 10;
            int b = 20;
            Console.WriteLine(a / b); //division
            Console.WriteLine(a % b); //modulus
            Console.WriteLine((double)a / b); //division with casting

            // increment and decrement operators
            int c = 6;
            Console.WriteLine(++c); //--c   5
            Console.WriteLine(c++); //c--  5
            Console.WriteLine(c); // c 4

            // assignment operators
            a += 5; // a = a + 5
            b *= 5; // b = b * 5
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            // comparison operators
            bool result = a < b;
            Console.WriteLine(result);

            Console.WriteLine(c == a);
            Console.WriteLine(c != b);
            Console.WriteLine(b >= a);

            // logical operators 
            
            Console.WriteLine(a < c && b > c);
            Console.WriteLine( !(a >= b) );
            Console.WriteLine(b >= a || c == a);

            // Expressions
            int e = 5, f = 10;
            int g = e + f; // arithmetic expression
            bool h = e < f; // logical (boolean) expression
            Console.WriteLine(g);
            Console.WriteLine(h);

            // Conditional operator (Ternary operator)
            // condition ? expression1 (T) : expression2 (F)
            int score = 92;
            string grade = score >= 50 ? "PASS" : "FAIL";
            Console.WriteLine(grade);

            // string concatenation
            string firstName = "Hager";
            string lastName = "Mina";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            // escape sequences
            char ch = '\\';
            string text = "Name:\t\"Hager\"\nAdress:\t\"switzerland\"";
            Console.WriteLine(text);
            Console.WriteLine(ch);

            // operator precedence
            int x = 2 + 2 * 2;
            Console.WriteLine(x);

            x = (2 + 2) * 2;
            Console.WriteLine(x);

            // operator associativity
            int y = 10 / 5 / 2; // y = 1
            Console.WriteLine(y);
            
            y = 10 / (5 / 2); // y = 5
            Console.WriteLine(y);

            // operand evaluation 
            bool z = a > b && b > c; // z = false 
            bool w = a < b || b == c; // w = true
            int m = a > b? x * y : x + y; // m = x + y 












        }
    }
}
