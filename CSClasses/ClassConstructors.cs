using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    //Create Class
    class ClassConstructors
    {
        public string model, color; //Create Field
        public int year; //Create Field

        //Create Class Constructor Without Parameter
        public ClassConstructors()
        {
            model = "Mustang"; //Set the initial value for the model
        }

        // Create a class constructor with a parameter
        public ClassConstructors(string modelName)
        {
            model = modelName;
        }

        //Create a class constructor with multiple parameters
        public ClassConstructors(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            ClassConstructors Ford1 = new ClassConstructors(); 
            //Create an object of the created Class (this will call the constructor)
            Console.WriteLine(Ford1.model); //Print value of Model
            ClassConstructors Ford2 = new ClassConstructors("Mustang");
            Console.WriteLine(Ford2.model);
            ClassConstructors Ford3 = new ClassConstructors("Mustang", "Red", 1966);
            Console.WriteLine(Ford3.color + " " + Ford3.year + " " + Ford3.model);
        }
    }
}
