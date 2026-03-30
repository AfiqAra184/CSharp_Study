using System; //using System means that we can use classes from the System namespace.

//A blank line. C# ignores white space. However, multiple lines makes the code more readable.

namespace CSharp_Tutorial //namespace is used to organize your code, and it is a container for classes and other namespaces.
{
    internal class Syntax //class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.
    {
        //static void Main(string[] args) //Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.
        //{
        //    Console.WriteLine("Hello, World!"); //Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example, it will output "Hello World!".
        //    //If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.
        //}
    }
}

/*
Note: Every C# statement ends with a semicolon ;.

Note: C# is case-sensitive; "MyClass" and "myclass" have different meaning.

Note: Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add ".cs" to the end of the filename.
 */