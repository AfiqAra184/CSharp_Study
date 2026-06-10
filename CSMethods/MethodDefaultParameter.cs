using System;
using System.Collections.Generic;
using System.Text;

namespace CSMethods
{
    internal class MethodDefaultParameter
    {
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }
        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
        }
    }
}
