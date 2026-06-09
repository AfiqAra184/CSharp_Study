using System;
using System.Collections.Generic;
using System.Text;

namespace CSMethods
{
    internal class MethodParameters
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        //Multiple Parameter
        static void MyMethod1(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
            MyMethod1("Liam", 5);
            MyMethod1("Jenny", 8);
            MyMethod1("Anja", 31);
        }
    }
}
