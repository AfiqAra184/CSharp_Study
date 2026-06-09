using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tutorial
{
    internal class CSBreakContinue
    {
        static void Main(string[] args)
        {
            //Break
            for(int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            //Continue
            for(int i = 0;i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
