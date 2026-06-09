using System;

namespace CSharp_Tutorial
{
    internal class CSMath
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-3.9));
            Console.WriteLine(Math.Round(8.76));
        }
    }
}
