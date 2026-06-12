using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CSClasses
{
    /*
    --------------------------------------------------------
    Inheritance (Derived and Base Class)
    --------------------------------------------------------
    In C#, it is possible to inherit fields and methods from 
    one class to another. We group the "inheritance concept" 
    into two categories:
    - Derived Class (child) - the class that inherits from 
      another class
    - Base Class (parent) - the class being inherited from

    To inherit from a class, use the : symbol.

    --------------------------------------------------------
    Why And When To Use "Inheritance"?
    --------------------------------------------------------
    It is useful for code reusability: reuse fields and 
    methods of an existing class when you create a new class

     */

    class Vehicle //Base Class (Parent)
    {
        public string brand = "Ford"; //Vehicle Field
        protected string owner = "Colonel"; //Protected Vehicle Field
        public void honk() //Vehicle Method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Cars : Vehicle //Derived Class (Child)
    {
        public string modelName = "Mustang"; //Car Field

        public void CarDetails()
        {
            Console.WriteLine(owner + " " + modelName);
        }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            //Create a myCar Object
            Cars myCar = new Cars();

            /*
            Call the honk() Method (From the vehicle Class)
            on the myCar Object
            */
            myCar.honk();
            myCar.CarDetails();
            /*
            Disply the Value of the brand Field (From the 
            Vehicle Class) and the Value of the modelName 
            from the Car Class
            */
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }

    /*
    --------------------------------------------------------
    The sealed Keyword
    --------------------------------------------------------
    If you don't want other classes to inherit from a class, 
    use the sealed keyword:
    
    If you try to access a sealed class, C# will generate an 
    error:
    sealed class Vehicle 
    {
        ...
    }
    class Car : Vehicle 
    {
        ...
    }
    */
}
