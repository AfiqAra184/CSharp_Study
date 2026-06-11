using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    /*
        --------------------------------------------------------------
        Properties and Encapsulation
        --------------------------------------------------------------
        Before we start to explain properties, you should have a basic 
        understanding of "Encapsulation".

        The meaning of Encapsulation, is to make sure that "sensitive" 
        data is hidden from users. To achieve this, you must:
        - declare fields/variables as private
        - provide public get and set methods, through properties, to 
          access and update the value of a private field
        --------------------------------------------------------------
        Properties
        --------------------------------------------------------------
        You learned from the previous chapter that private variables 
        can only be accessed within the same class (an outside class 
        has no access to it). However, sometimes we need to access 
        them - and it can be done with properties.

        A property is like a combination of a variable and a method, 
        and it has two methods: a get and a set method
        --------------------------------------------------------------
        Why Encapsulation?
        --------------------------------------------------------------
        - Better control of class members (reduce the possibility of 
          yourself (or others) to mess up the code)
        - Fields can be made read-only (if you only use the get 
          method), or write-only (if you only use the set method)
        - Flexible: the programmer can change one part of the code 
          without affecting other parts
        - Increased security of data
    */
    class Person1
    {
        private string name; //Field

        public string Name //Property
        {
            get { return name; } //Get Method
            set { name = value; } //Set Method
        }
    }
    class Person2
    {
        //Automatic Properties (Short Hand)
        public string Name //Property
        { get; set; }
    }
    class PropertiesGetAndSet
    {
        static void Main(string[] args)
        {
            Person1 myObj1 = new Person1();
            myObj1.Name = "Liam";
            Console.WriteLine(myObj1.Name);
            Person2 myObj2 = new Person2();
            myObj2.Name = "Liam";
            Console.WriteLine(myObj2.Name);
        }
    }
}
