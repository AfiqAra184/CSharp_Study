using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    class MultiClassesAndObjects
    {
        string color = "red";
        static void Main(string[] args)
        {
            MultiClassesAndObjects myObj1 = new MultiClassesAndObjects();
            MultiClassesAndObjects myObj2 = new MultiClassesAndObjects();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);

            //Access different class (in MultiClassesAndObjects2.cs)
            MultiClassesAndObjects2 myObj3 = new MultiClassesAndObjects2();
            Console.WriteLine(myObj3.color);

            MultiClassesAndObjects3 myObj4 = new MultiClassesAndObjects3();
            Console.WriteLine(myObj4.color);
        }
    }

    class MultiClassesAndObjects3
    {
        public string color = "red";
    }
}
