using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace CSClasses
{
    /*
    C# has the following access modifiers:
    |------------------------------------------------------------------|
    | Modifier    |  Description                                       |
    |-------------|----------------------------------------------------|
    | public      |  The code is accessible for all classes.           |
    | private     |  The code is only accessible within the same class.|
    | protected   |  The code is accessible within the same class, or  |
    |             |  in a class that is inherited from that class. You |
    |             |  will learn more about inheritance in a later      |
    |             |  chapter.                                          |
    | internal    |  The code is only accessible within its own        |   
    |             |  assembly, but not from another assembly.You will  |
    |             |  learn more about this in a later chapter.         |
    |------------------------------------------------------------------|

    Why Access Modifiers?
    
    To control the visibility of class members (the security level of 
    each individual class and class member).
    
    To achieve "Encapsulation" - which is the process of making sure 
    that "sensitive" data is hidden from users. This is done by 
    declaring fields as private. You will learn more about this in the 
    next chapter.

    By default, all members of a class are private if you don't specify 
    an access modifier
    */

    //Another Class
    class Car
    {
        //Public Access Modifier
        public string model = "Mustang";
    }
    class AccessModifiers
    {
        //Private Access Modifier
        private string model = "Mustang";

        static void Main(string[] args)
        {
            AccessModifiers myObj1 = new AccessModifiers();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.model);
            Console.WriteLine(myObj2.model);
        }
    }
}
