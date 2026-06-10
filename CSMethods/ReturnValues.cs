using System;
using System.Collections.Generic;
using System.Text;

namespace CSMethods
{
    internal class ReturnValues
    {
        static int MyMethod(int x)
        {
            return 5 + x;
        }
        static int MyMethod1(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
            Console.WriteLine(MyMethod1(5, 3));
            int z = MyMethod1(5, 3);
            Console.WriteLine(z);
        }
    }
}
