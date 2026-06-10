using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    //The Class
    class ClassMember
    {
        //Class Members
        string model, mColor, color = "red";    //Field
        int year, maxSpeed = 200;               //Field
        public void fullThrottle() //Method
        {
            Console.WriteLine("the car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            //A static method can be accessed without creating an
            //object of the class, while public methods can only
            //be accessed by objects.
            ClassMember myObj = new ClassMember();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.color = "black";
            Console.WriteLine(myObj.color);
            myObj.fullThrottle(); //Accessing Method

            ClassMember Ford = new ClassMember();
            Ford.model = "Mustang";
            Ford.mColor = "red";
            Ford.year = 1969;

            ClassMember Opel = new ClassMember();
            Opel.model = "Astra";
            Opel.mColor = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
