using System;

namespace CSharp_Tutorial
{
    internal class CSString
    {
        static void Main(string[] args)
        {
            //Strings
            string greeting = "Hello";
            string greeting2 = "Assalamualaikum Warahmatullahi Wabarakatuh";
            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            Console.WriteLine("The length of the greeting2 string is: " + greeting2.Length);

            Console.WriteLine("All uppercase: " + greeting2.ToUpper());
            Console.WriteLine("All lowercase: " + greeting2.ToLower());

            //Concatenation
            string fName = "Muhammad Afiq ";
            string lName = "Mohd Ara";
            string name = fName + lName;
            Console.WriteLine(name);

            string fName2 = "Nur Syahirah Natasya ";
            string lName2 = "Sumiati";
            string name2 = string.Concat(fName2, lName2);
            Console.WriteLine(name2);

            //C# uses the + operator for both addition and concatenation

            //String Interpolation
            string fName3 = "Afiq", lName3 = "Ara", name3 = $"My full name is: {fName3} {lName3}";
            Console.WriteLine(name3);

            //Access String
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name.IndexOf("Ar"));
            int charPos = name.IndexOf("Mo");
            string lastName = name.Substring(charPos);
            Console.WriteLine(lastName);

            //Special Character
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);
            txt = "It\'s alright";
            Console.WriteLine(txt);
            txt = "The character \\ is called backlash";
            Console.WriteLine(txt);
            txt = "New Line \nHere";
            Console.WriteLine(txt);
            txt = "Tab \tHere";
            Console.WriteLine(txt);
            txt = "Backspace \bHere";
            Console.WriteLine(txt);
        }
    }
}
