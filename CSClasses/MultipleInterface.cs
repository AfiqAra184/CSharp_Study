using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    interface IFirstInterface
    {
        void myMethod(); //Interface Method
    }
    interface ISecondInterface
    {
        void myOtherMethod(); //Interface Method
    }
    //Implement Multiple Interface
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text...");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
    class MultipleInterface
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
