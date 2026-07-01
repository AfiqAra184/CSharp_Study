namespace Exercise
{
    //Menu Actions
    interface IMenuAction
    {
        //public execute;
        //make it async
        Task Execute();
    }

    class CatalogAction : IMenuAction
    {
        private readonly string[] _names;
        private readonly double[] _prices;
        private readonly int[] _stock;
        public CatalogAction(string[] names, double[] prices, int[] stock)
        {
            _names = names;
            _prices = prices;
            _stock = stock;
        }
        public async Task Execute()
        {
            Console.Clear();
            Console.WriteLine("Store Catalog");

            for (int i = 0; i < _names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {_names[i]} - RM{_prices[i]:F2} (Stock: {_stock[i]})");
            }

            Console.WriteLine("\nPress any key to return to the menu");
            Console.ReadKey(true);
        }
    }

    class OrderAction(string[] names, double[] prices, int[] stock) : IMenuAction
    {
        /*private readonly string[] _names;
        private readonly double[] _prices;
        private readonly int[] _stock;
        public OrderAction(string[] names, double[] prices, int[] stock)
        {
            _names = names;
            _prices = prices;
            _stock = stock;
        }*/
        public async Task Execute()
        {
            Console.Clear();

            Console.WriteLine("Enter the item name you want to buy: ");
            string? userInput = Console.ReadLine();
            //use string? if  have Nullable Reference Types enabled
        }
    }
    class ExitAction : IMenuAction
    {
        private readonly Action _changeFlag;
        public ExitAction(Action changeFlag)
        {
            _changeFlag = changeFlag;
        }
        public async Task Execute()
        {
            Console.Clear();
            //continueOrder = false;
            await e01.TypeWriterFX("Thank you!!", 20);
            _changeFlag();
        }
    }
    internal class e01
    {
        //The Challenge: The Smart Inventory & Order Manager

        /*
        Phase 1: Setup & Data (Variables, Data Types, Arrays)
        1. Create a fixed array of strings for itemNames containing 
           4 items (e.g., "Laptop", "Mouse", "Keyboard", "Monitor").
        2. Create a parallel array of doubles for itemPrices 
           containing the price for each item respectively (e.g., 
           1200.00, 25.50, 45.00, 150.00).
        3. Create a parallel array of integers for itemStock 
           representing how many of each item are available in the 
           store (e.g., 5, 10, 8, 3).

        Phase 2 :The Main Menu (Loops, Output, Switch)
        1. Wrap your entire application in a while loop so it keeps 
           running until the user decides to exit.
        2. Every time the loop runs, clear the console or print a 
           clean menu:
            Option 1: View Catalog
            Option 2: Place an Order.
            Option 3: Exit.
        3. Use a switch statement to handle the user's menu choice.

        Phase 3: Ordering Logic (User Input, If...Else, 
        Break/Continue)
        If the user chooses Option 2 (Place an Order):
        1. Ask them to type the name of the item they want.
        2. Search through your itemNames array using a loop.
            - If the item isn't found, print an error message and 
              use continue or break to return to the main menu.
            - If it is found, check the itemStock. If stock is 0, 
              tell them it's out of stock.
        3. If it's in stock, ask them how many they want to buy.
        4. Use an if...else statement to verify if you have enough 
        stock.
            - If yes, deduct that amount from the itemStock array 
              and proceed to calculation.
            - If no, tell them you don't have enough stock and 
              cancel the transaction.
        
        Phase 4: The Bill Calculation (Math, Strings, Booleans)
        1. Calculate the subtotal (Price $\times$ Quantity).
        2. Create a boolean variable hasDiscount. If the subtotal is 
           over $100 (or 100 RM), set it to true and apply a 10% 
           discount. Otherwise, it's false.
        3. Add a standard 6% service tax to the final amount after 
           the discount.
        4. Output a clean, formatted receipt string using string 
           interpolation ($""). Show:
            - Item ordered and quantity.
            - Subtotal.
            - Discount applied (Yes/No).
            - Final Total (rounded to 2 decimal places using 
              Math.Round()).
        */

        //Typewriter effect on console
        public static async Task TypeWriterFX(string message, int delay = 50)
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

            bool continueOrder = true;

            do
            {
                Console.Clear(); //Clear Console

                //Console.WriteLine("What would you like to do: ");
                await TypeWriterFX("What would you like to do: ", 30);
                Console.WriteLine("1. View Catalog \n2. Place an Order \n3. Exit\nSelect an option..");

                // == FIX: FLUSH KEYBOARD BUFFER HERE ==
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                ConsoleKeyInfo choice = Console.ReadKey(true);

                //Using Switch
                //Using class inside switch
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CatalogAction Catalog = new CatalogAction(itemNames, itemPrices, itemStock);
                        await Catalog.Execute();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        OrderAction Order = new OrderAction(itemNames, itemPrices, itemStock);
                        await Order.Execute();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //Console.Clear();
                        //continueOrder = false;
                        //await TypeWriterFX("Thank you!!", 20);
                        
                        ExitAction Exit = new ExitAction(() => continueOrder = false);
                        await Exit.Execute();
                        break;
                    default:
                        Console.Clear();
                        await TypeWriterFX("Please choose between 1, 2 & 3...");
                        //Console.ReadKey();
                        await Task.Delay(1500);
                        break;
                }

                

            } while(continueOrder);

        }
    }
}
