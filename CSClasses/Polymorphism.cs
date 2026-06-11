using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    class Animal //Base Class (Parent)
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal //Derived Class (Child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }

    }
    class Dog : Animal //Derived Class(Child)
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
