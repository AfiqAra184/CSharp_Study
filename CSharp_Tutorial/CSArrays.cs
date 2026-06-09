using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp_Tutorial
{
    internal class CSArrays
    {
        static void Main(string[] args)
        {
            //Arrays
            string[] cars = { "Volvo", "BMW", "Ford" };
            Console.WriteLine(cars[0]);

            cars[1] = "Toyota";
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars.Length);

            // Create an array of four elements, and add values later
            string[] array1 = new string[4];
            // Add values, using new
            array1 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements and add values right away
            string[] array2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements without specifying the size 
            string[] array3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] array4 = { "Volvo", "BMW", "Ford", "Mazda" };

            //Loop Through an Array
            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars1.Length; i++)
            {
                Console.WriteLine(cars1[i]);
            }

            //Foreach Loop
            foreach (string i in cars1)
            {
                Console.WriteLine(i);
            }

            //Sort an Array
            Console.WriteLine("Sorting an Array");
            //Sort a string
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda", "BMW" };
            Array.Sort(cars2);
            foreach (string i in cars2)
            {
                Console.WriteLine(i);
            }
            //Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            //Other useful array methods
            int[] myNumbers1 = { 5, 1, 8, 9 };
            Console.WriteLine("Max, Min Sum methods in System.Linq namespace");
            Console.WriteLine(myNumbers1.Max());
            Console.WriteLine(myNumbers1.Min());
            Console.WriteLine(myNumbers.Sum());

            //Multidimensional Arrays
            Console.WriteLine("Multidimensional Array and Changing the element");
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine("numbers[0, 0] is " + numbers[0, 0]);
            numbers[0, 0] = 5;
            Console.WriteLine("numbers[0, 0] is now " + numbers[0, 0]);

            Console.WriteLine("Foreach Loop 2d Array");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Array.Sort(numbers);

            Console.WriteLine("For Loop 2d Array");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }
        }
    }
}
