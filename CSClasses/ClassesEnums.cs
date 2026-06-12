using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    /*
    --------------------------------------------------------
    C# Enums
    --------------------------------------------------------
    An enum is a special "class" that represents a group of 
    constants (unchangeable/read-only variables).

    To create an enum, use the enum keyword (instead of 
    class or interface), and separate the enum items with a 
    comma

    --------------------------------------------------------
    Enum Values
    --------------------------------------------------------
    By default, the first item of an enum has the value 0. 
    The second has the value 1, and so on.
    
    To get the integer value from an item, you must 
    explicitly convert the item to an int

    You can also assign your own enum values, and the next 
    items will update their numbers accordingly

    */
    class ClassesEnums
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        enum Months
        {
            January,    //0
            February,   //1
            March = 6,  //2 -> 6
            April,      //3 -> 7
            May,        //4 -> 8
            Jun,        //5 -> 9
            July        //6 -> 10
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

            int myNum1 = (int) Months.February, myNum2 = (int) Months.April;
            Console.WriteLine(myNum1);
            Console.WriteLine(myNum2);

            //Switch Statement
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;
            }
        }
    }
}
