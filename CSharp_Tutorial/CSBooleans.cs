using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    internal class CSBooleans
    {
        static void Main(string[] args)
        {
            bool x = true, y = false;
            Console.WriteLine(y + " " + x);

            int a = 10, b = 9;
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);

            int myAge = 25, votingAge = 18;
            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote");
            }
        }
    }
}
