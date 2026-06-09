using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    internal class CSForLoop
    {
        static void Main(string[] args)
        {
            //For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //Nested Loops
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Outer: " + i);

                for (int j= 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);
                }
            }

            //Foreach Loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
