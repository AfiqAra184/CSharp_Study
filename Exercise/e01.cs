namespace Exercise
{
    internal class e01
    {
        //The Challenge: The Smart Inventory & Order Manager

        /*
        Setup & Data (Variables, Data Types, Arrays)
        1. Create a fixed array of strings for itemNames containing 
           4 items (e.g., "Laptop", "Mouse", "Keyboard", "Monitor").
        2. Create a parallel array of doubles for itemPrices 
           containing the price for each item respectively (e.g., 
           1200.00, 25.50, 45.00, 150.00).
        3. Create a parallel array of integers for itemStock 
           representing how many of each item are available in the 
           store (e.g., 5, 10, 8, 3).

        The Main Menu (Loops, Output, Switch)
        1. Wrap your entire application in a while loop so it keeps 
           running until the user decides to exit.
        2. Every time the loop runs, clear the console or print a 
           clean menu:
            Option 1: View Catalog
            Option 2: Place an Order.
            Option 3: Exit.
        3. Use a switch statement to handle the user's menu choice.
        */

        static async Task TypeWriterFX(string message, int delay = 50)
        {
            foreach (char letter in message)
            {
                Console.Write(letter);
                await Task.Delay(delay);
            }
            Console.WriteLine();
        }
        static async Task Main(string[] args)
        {
            string[] itemNames = {"Laptop", "Mouse", "Keyboard", "Monitor"};
            double[] itemPrices = {12000.00, 25.50, 45.00, 150.00};
            int[] itemStock = {5, 10, 8, 3};
            //Side note: if need to do an array that can increase it size or shrink, can use List
            //BUT, List will have slightly more memory/CPU overhead	while Array is fast, memory-efficient, lightweight

            /*
            Console.WriteLine("Welcome to AiTea!");
            Thread.Sleep(800); //Using Thread
            */

            await TypeWriterFX("Welcome to AiTea!");
            Console.WriteLine("Press any key or wait for 5 seconds to proceed...");

            /* 
            Using for loop instead of async

            //Iterations x Sleep Time = 2000ms (2 seconds)
            for (int i = 0; i < 50; i++)
            {
                //Keyboard Buffer Storage Area
                if (Console.KeyAvailable) //Check Keyboard Buffer
                {
                    //Clear Keyboard Buffer without displaying the Character by using 'true'
                    Console.ReadKey(true); 
                    break;
                }
                System.Threading.Thread.Sleep(100); //Waits for 0.1 seconds (100 milliseconds)
                //Can also use await Task.Delay(100);
            }
            */

            await Task.WhenAny(Task.Delay(5000), Task.Run(() => Console.ReadKey(true)));
            /*
             * Thread
             * WhenAny, Delay and 
             * Async and Await
             * Delegate
             * Lambda
             */


            Console.Clear(); //Clear Console
            bool continueOrder = true;

            do
            {
                //Console.WriteLine("What would you like to do: ");
                await TypeWriterFX("What would you like to do: ", 30);
                Console.WriteLine("1. View Catalog \n2. Place an Order \n3. Exit\nSelect an option..");
                ConsoleKeyInfo choice = Console.ReadKey(true);

                //Using Switch
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        continueOrder = false;
                        await TypeWriterFX("Thank you!!", 20);
                        break;
                    default:
                        //Console.Clear();
                        await TypeWriterFX("Please choose between 1, 2 & 3...");
                        Console.ReadKey();
                        break;
                }

            } while(continueOrder);
        }
    }
}
