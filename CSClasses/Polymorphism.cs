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
    class Dragon : Animal //Derived Class(Child)
    {
        public void animalSound()
        {
            Console.WriteLine("The dragon says: rawr rawr");
        }
    }
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();
            Animal myDragon = new Dragon();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            myPig.animalSound();
            myDragon.animalSound(); //Is not override
        }
    }
}
