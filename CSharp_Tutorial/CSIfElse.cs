using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    internal class CSIfElse
    {
        static void Main(string[] args)
        {
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            time = 12;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            //Shorthand if else (Ternary Operator)
            //variable = (condition) ? expressionTrue :  expressionFalse;
            string result = (time < 10) ? "Good day" : "Good evening";
            Console.WriteLine(result);
        }
    }
}
