using System;
using System.Collections.Generic;
using System.Text;

namespace CSClasses
{
    class Exceptions
    {
        static void checkAge(int age)
        {
            //The Throw Keyword
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        static void Main(string[] args)
        {
            //Try and Catch
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                //Using built-in message
                Console.WriteLine(e.Message);
            }

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }

            //Finally
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            //Test the Throw Keyword
            checkAge(15);
        }
    }
}
