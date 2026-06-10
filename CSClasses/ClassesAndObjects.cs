using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    class ClassesAndObjects
    {
        string color = "red";

        static void Main(string[] args)
        {
            ClassesAndObjects myObj = new ClassesAndObjects();
            Console.WriteLine(myObj.color);
        }
    }
}
