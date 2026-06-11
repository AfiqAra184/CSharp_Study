using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    /*
    --------------------------------------------------------
    Interface
    --------------------------------------------------------
    Another way to achieve abstraction in C#, is with 
    interfaces.
    
    An interface is a completely "abstract class", which can 
    only contain abstract methods and properties (with empty 
    bodies)

    --------------------------------------------------------
    Notes on Interfaces:
    --------------------------------------------------------
    - Like abstract classes, interfaces cannot be used to 
      create objects (in the example above, it is not 
      possible to create an "IAnimal" object in the Program 
      class)
    - Interface methods do not have a body - the body is 
      provided by the "implement" class
    - On implementation of an interface, you must override 
      all of its methods
    - Interfaces can contain properties and methods, but not 
      fields/variables
    - Interface members are by default abstract and public
    - An interface cannot contain a constructor (as it cannot 
      be used to create objects)

    --------------------------------------------------------
    Why And When To Use Interfaces?
    --------------------------------------------------------
    1) To achieve security - hide certain details and only 
       show the important details of an object (interface).
    2) C# does not support "multiple inheritance" (a class 
       can only inherit from one base class). However, it can 
       be achieved with interfaces, because the class can 
       implement multiple interfaces. Note: To implement 
       multiple interfaces, separate them with a comma
    */

    //Interface
    interface IAnimal
    {
        void animalSound(); //Interface Method (does not have a body)
    }
    // Pig3 "Implements" the IAnimal interface
    class Pig3 : IAnimal
    {
        public void animalSound()
        {
            //The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    interface IPlayable
    {
        void play(); //Interface Method (does not have a body)
    }
    class pig4 : IAnimal, IPlayable
    {
        //Fullfilling the contract for IAnimal
        public void animalSound()
        {
            Console.WriteLine("The pig says: whee whee");
        }
        //Fullfilling the contract for IPlayable
        public void play()
        {
            Console.WriteLine("The pig rolls around in the mud happily!");
        }
    }
    class Interface
    {
        static void Main(string[] args)
        {
            Pig3 myPig = new Pig3(); //Create a Pig3 Object
            myPig.animalSound();
            pig4 myPig2 = new pig4();
            myPig2.animalSound(); // Call the IAnimal method
            myPig2.play(); // Call the IPlayable method
        }
    }
}
