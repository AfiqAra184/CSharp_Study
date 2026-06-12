using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.IO.Enumeration;  // include the System.IO namespace

namespace CSClasses
{
    /*
    --------------------------------------------------------
    Working With Files
    --------------------------------------------------------
    The File class from the System.IO namespace, allows us 
    to work with files

    The File class has many useful methods for creating and 
    getting information about files.

    ----------------------------------------------------------
    |Method         |Description                             |
    |---------------|----------------------------------------|
    |AppendText()   |Appends text at the end of an existing  |
    |               |file                                    |               
    |Copy()         |Copies a file                           |
    |Create()	    |Creates or overwrites a file            |               
    |Delete()	    |Deletes a file                          |
    |Exists()	    |Tests whether the file exists           |
    |ReadAllText()	|Reads the contents of a file            |
    |Replace()	    |Replaces the contents of a file with the| 
    |               |contents of another file                |
    |WriteAllText()	|Creates a new file and writes the       |
    |               |contents to it. If the file already     |
    |               |exists, it will be overwritten.         |
    ----------------------------------------------------------
    */
    class ClassesFiles
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World"; // Create a text string
            File.WriteAllText("filename.txt", writeText); // Create a file and write the contents of writeText to it
            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}
