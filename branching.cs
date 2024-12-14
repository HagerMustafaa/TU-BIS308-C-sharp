using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the score: ");
            int score = int.Parse(Console.ReadLine());

            /* if statement */

             if (score >= 50) 
             {
                 Console.WriteLine("pass");
             }
             Console.WriteLine("end of program");
            

            /* if..else */

             if (score >= 50)
             {
                 Console.WriteLine("pass");
             }
             else
             {
                 Console.WriteLine("fail");
             }
             Console.WriteLine("end of program"); 

            /* nested if */

            if (score >= 85)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                if (score >= 75)
                {
                    Console.WriteLine("Very Good");
                }
                else
                {
                    if (score >= 65)
                    {
                        Console.WriteLine("Good");
                    }
                    else
                    {
                        if (score >= 50)
                        {
                            Console.WriteLine("pass");
                        }
                        else
                        {
                            Console.WriteLine("fail");
                        }
                    }
                }
            }

            /* switch statement */

            Console.Write(" enter a weekday number : ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("saturday");
                    break;  
                case 2:
                    Console.WriteLine("sunday");
                    break;
                case 3:
                    Console.WriteLine("monday");
                    break;
                case 4:
                    Console.WriteLine("tuesday");
                    break;
                case 5:
                    Console.WriteLine("wensday");
                    break;
                case 6:
                    Console.WriteLine("thursday");
                    break;
                case 7:
                    Console.WriteLine("friday");
                    break;
            }

            /* default case */

            Console.Write("enter the traffic light color: ");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.WriteLine("stop");
                    break;
                case "yellow":
                    Console.WriteLine("caution");
                    break;
                case "green":
                    Console.WriteLine("go");
                    break;
                default:
                    Console.WriteLine("invalid color");
                    break;
            }







        }
    }
}