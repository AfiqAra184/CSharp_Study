using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    internal class CSWhileLoop
    {
        static void Main(string[] args)
        {
            //While Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //Do While Loop
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }
    }
}
