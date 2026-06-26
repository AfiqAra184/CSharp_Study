using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    internal class e02
    {
        public static void Main()
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            do
            {
                cki = Console.ReadKey();
                Console.Write(" --- You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape);
        }

        /*
        ---------------------------------------------------------------------------
        Remarks
        ---------------------------------------------------------------------------
        The ConsoleKeyInfo type is not intended to be created by users. Instead, it
        is returned to the user in response to calling the Console.ReadKey method.
        
        The ConsoleKeyInfo object describes the ConsoleKey constant and Unicode 
        character, if any, that correspond to the pressed console key. The 
        ConsoleKeyInfo object also describes, in a bitwise combination of 
        ConsoleModifiers values, whether one or more SHIFT, ALT, or CTRL modifier 
        keys was pressed simultaneously with the console key.

        */
    }
}
