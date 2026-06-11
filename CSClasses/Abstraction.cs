using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    /*
    --------------------------------------------------------
    Abstract Classes and Methods
    --------------------------------------------------------
    Data abstraction is the process of hiding certain 
    details and showing only essential information to the 
    user.
    Abstraction can be achieved with either abstract classes 
    or interfaces (which you will learn more about in the 
    next chapter).
    
    The abstract keyword is used for classes and methods:
    - Abstract class: is a restricted class that cannot be 
      used to create objects (to access it, it must be 
      inherited from another class).
    - Abstract method: can only be used in an abstract class
      and it does not have a body. The body is provided by
      the derived class (inherited from).

    An abstract class can have both abstract and regular 
    methods
    */
    
    //Abstract Class
    abstract class Animal2
    {
        //Abstract Method
        public abstract void animalSound();
        //Regular Method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    //Derived Class (Inherit From Animal)
    class Pig2 : Animal2 //Implement
    {
        public override void animalSound()
        {
            //The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Abstraction
    {
        static void Main(string[] args)
        {
            Pig2 myPig = new Pig2(); //Create a Pig2 Object
            myPig.animalSound(); //Call the Abstract Method
            myPig.sleep(); //Call the Regular Method
        }
    }
}
