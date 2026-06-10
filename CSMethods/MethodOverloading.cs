using System;
using System.Collections.Generic;
using System.Text;

namespace CSMethods
{
    internal class MethodOverloading
    {
        static int PlusMethod(int x)
        {
            return x;
        }
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(7);
            int myNum2 = PlusMethod(8, 5);
            double myNum3 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " +  myNum1);
            Console.WriteLine("IntSum: " + myNum2);
            Console.WriteLine("DoubleSum: " + myNum3);
        }
    }
}
